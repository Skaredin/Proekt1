using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v3.Properties
{
    public partial class Products : Form
    {
        int rowCount = 0;
        public Products()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dv3_403DataSet);

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dv3_403DataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.dv3_403DataSet.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dv3_403DataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.dv3_403DataSet.Product);
            try
            {
                foreach (DataGridViewRow item in this.productDataGridView.Rows)
                {
                    if (!Convert.ToBoolean(item.Cells[5].Value))
                    {
                        item.DefaultCellStyle.BackColor = Color.Gray;
                    }
                    int id = Convert.ToInt32(item.Cells[0].Value);
                    AttachedProd attachedProd = dv3_403Entities.GetContext().AttachedProds.Where(x => x.ID == id).FirstOrDefault();
                    item.Cells[2].Value = item.Cells[1].Value.ToString() + " (" + attachedProd.ProdCount.ToString() + ")";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            manufactureComboBox.Items.Add("Все элементы"); //add
            var cmb = dv3_403Entities.GetContext().Manufacturers.ToList();
            foreach (Manufacturer item in cmb)
            {
                manufactureComboBox.Items.Add(item.ID.ToString());
            }

            manufactureComboBox.Text = "Все элементы";
            searchTextBox.Text = "";

            rowCount = productDataGridView.Rows.Count;
            countLabel.Text = productDataGridView.Rows.Count + " из" + rowCount;
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UpdateFilter()
        {
            try
            {
                foreach (DataGridViewRow item in this.productDataGridView.Rows)
                {
                    if (!Convert.ToBoolean(item.Cells[5].Value))
                    {
                        item.DefaultCellStyle.BackColor = Color.Gray;
                    }
                }

                countLabel.Text = productDataGridView.Rows.Count + " из" + rowCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            EditProduct edit = new EditProduct();
            edit.Show();
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct add = new AddProduct(1);
            add.Show();
        }

        private void productDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in this.productDataGridView.Rows)
            {
                if (e.ColumnIndex == Convert.ToInt32(item.Cells[0].Value))
                {
                    this.Hide();
                    SaleProduct sale = new SaleProduct(e.RowIndex);
                    sale.Show();
                }
            }
        }

        private void searchTextBox_TextChanged_1(object sender, EventArgs e)
        {
            productBindingSource.Filter = "Title like'*" + searchTextBox.Text + "*' or Description like'*" + searchTextBox.Text + "'";

            UpdateFilter();
        }

        private void manufactureComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (manufactureComboBox.Text != "Все элементы")
                productBindingSource.Filter = $"ManufacturerID = '{manufactureComboBox.Text}'";
            else
                productBindingSource.Filter = string.Empty;

            UpdateFilter();
        }

        private void saleBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            productBindingSource.Filter = string.Empty;
            asRadioButton.Checked = false;
            desRadioButton.Checked = false;
            manufactureComboBox.Text = "Все элементы";
            searchTextBox.Text = "";
            UpdateFilter();
        }

        private void desRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            if (desRadioButton.Checked)
                productDataGridView.Sort(productDataGridView.Columns[3], ListSortDirection.Descending);

            UpdateFilter();
        }

        private void asRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            if (asRadioButton.Checked)
                productDataGridView.Sort(productDataGridView.Columns[3], ListSortDirection.Ascending); 

            UpdateFilter();
        }

        private void delBtn_Click_1(object sender, EventArgs e)
        {
            int delID = 0;
            try
            {
                if (productDataGridView.SelectedRows.Count == 1)
                {
                    foreach (DataGridViewRow item in this.productDataGridView.Rows)
                    {
                        delID = Convert.ToInt32(item.Cells[0].Value);
                    }
                    if (MessageBox.Show("Вы действительно хотите удалить выбранный товар?", "Удаление", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            Product product = dv3_403Entities.GetContext().Products.Where(x => x.ID == delID).FirstOrDefault();

                            dv3_403Entities.GetContext().Products.Remove(product);
                            dv3_403Entities.GetContext().SaveChanges();
                            MessageBox.Show("Данные успешно удалены!");

                            this.productTableAdapter.Fill(this.dv3_403DataSet.Product);
                            UpdateFilter();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("У данного товара уже есть информация о продаже, поэтому вы не можете его удалить!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать только одну строку для удаления!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
