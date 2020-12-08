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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dv3_403DataSet);

        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dv3_403DataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.dv3_403DataSet.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dv3_403DataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.dv3_403DataSet.Product);
            photoPictureBox.Image = Image.FromFile(mainImagePathComboBox.Text.Replace(@" ", @""));
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

        private void photoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void photoPictureBox_MouseHover(object sender, EventArgs e)
        {
            nameLabel.Text = titleTextBox.Text;
            costNameLabel.Text = costTextBox.Text;
        }
    }
}
