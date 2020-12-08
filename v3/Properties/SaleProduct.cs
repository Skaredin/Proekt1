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
    public partial class SaleProduct : Form
    {
        int? id;
        public SaleProduct(int? product)
        {
            InitializeComponent();
            id = product;
        }

        private void productSaleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productSaleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dv3_403DataSet);


        }

        private void SaleProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dv3_403DataSet.ProductSale". При необходимости она может быть перемещена или удалена.
            this.productSaleTableAdapter.Fill(this.dv3_403DataSet.ProductSale);

            if (id != null)
                productSaleBindingSource.Position = id.Value;

            try
            {
                foreach (DataGridViewRow item in this.productSaleDataGridView.Rows)
                {
                    productSaleDataGridView.Sort(productSaleDataGridView.Columns[1], ListSortDirection.Descending);
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
    }
}
