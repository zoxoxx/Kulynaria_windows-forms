using Kulynaria_Altashev.Classes;
using Kulynaria_Altashev.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kulynaria_Altashev.Forms
{
    public partial class Delete_SearchForm : Form
    {
        List<Product> products = new List<Product>();
        int indexp = 0;
        public Delete_SearchForm()
        {
            InitializeComponent();
            dgv_products.Columns[0].DataPropertyName = "Id";
            dgv_products.Columns[1].DataPropertyName = "ProductName";
            dgv_products.Columns[2].DataPropertyName = "Belki";
            dgv_products.Columns[3].DataPropertyName = "Zhire";
            dgv_products.Columns[4].DataPropertyName = "Uglev";
        }

        private void Delete_SearchForm_Load(object sender, EventArgs e)
        {
            products = ProductFromDb.loadProducts();
            dgv_products.DataSource = products;
        }

        private List<Product> SearchProducts(string txbSearch)
        {
            List<Product> productSearch = new List<Product>();

            foreach (Product item in products)
            {
                if (item.ProductName.StartsWith(txbSearch))
                {
                    productSearch.Add(item);
                }
            }
            return productSearch;
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            dgv_products.DataSource= SearchProducts(tb_search.Text);
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            AddProductForm add = new AddProductForm();
            this.Hide();
            add.ShowDialog();
        }

        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            ProductFromDb.DeleteProduct(products[indexp].Id);
            products = ProductFromDb.loadProducts();
            dgv_products.DataSource = products;
        }

        private void dgv_products_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexp = dgv_products.SelectedRows[0].Index;
            
        }
    }
}
