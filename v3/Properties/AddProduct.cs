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
    public partial class AddProduct : Form
    {
        int id;
        public AddProduct(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dv3_403DataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.dv3_403DataSet.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dv3_403DataSet.ProductPhoto". При необходимости она может быть перемещена или удалена.
            this.productPhotoTableAdapter.Fill(this.dv3_403DataSet.ProductPhoto);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dv3_403DataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.dv3_403DataSet.Product);

            if (id != -1)
                productBindingSource.Filter = $"Id = '{id}'";
            else
                productBindingSource.AddNew();

            //mainImagePathComboBox.Text = "Товарыавтосервиса\\8FE07916.jpg";
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dv3_403DataSet);

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите добавить данные?", "Сохранение", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Validate();
                    this.productBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dv3_403DataSet);
                    MessageBox.Show("Данные успешно сохранены!");
                    this.productTableAdapter.Fill(this.dv3_403DataSet.Product);

                    this.Hide();
                    Products products = new Products();
                    products.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products products = new Products();
            products.Show();
        }

        private void mainImagePathComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                photoPictureBox.Image = Image.FromFile(mainImagePathComboBox.Text.Replace(@" ", @""));

            }
            catch (Exception)
            {

            }
        }
    }
}
