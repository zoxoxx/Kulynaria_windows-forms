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
    public partial class KriteryeForm : Form
    {
        public List<Bludo> bludos = new List<Bludo>();
        BludaFromDB bludaFromDB = new BludaFromDB();
        public List<Product> products = new List<Product>();
        ProductFromDb productFromDb = new ProductFromDb();
        string check_product;
        public KriteryeForm()
        {
            InitializeComponent();
            dgv_bluda.Columns[0].DataPropertyName = "Identityb";
            dgv_bluda.Columns[1].DataPropertyName = "Bludo_image";
            dgv_bluda.Columns[2].DataPropertyName = "bludo";
            dgv_bluda.Columns[3].DataPropertyName = "Numbo";
            dgv_bluda.Columns[4].DataPropertyName = "Osnova";
            dgv_bluda.Columns[5].DataPropertyName = "Vyhod";

            dgv_products.Columns[0].DataPropertyName = "Id";
            dgv_products.Columns[1].DataPropertyName = "ProductName";
            dgv_products.Columns[3].DataPropertyName = "Belki";
            dgv_products.Columns[4].DataPropertyName = "Zhire";
            dgv_products.Columns[5].DataPropertyName = "Uglev";
        }
        private void ViewAllBludos()
        {
            bludos = bludaFromDB.loadBludos();
            dgv_bluda.DataSource = bludos;
        }
        private void ViewAllProducts ()
        {
            products = ProductFromDb.loadProducts();
            dgv_products.DataSource = products;

        }

        private void KriteryeForm_Load(object sender, EventArgs e)
        {
            ViewAllBludos();
            ViewAllProducts();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MainForm fff = new MainForm();
            this.Hide();
            fff.ShowDialog();
        }

        private void btn_search_on_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder("SELECT * from bluda join products on products.identificator = bluda.identityb WHERE  ");
            
            for (int i = 0; i < dgv_products.RowCount - 1; i++)
            {
                if (i == 0)
                {
                    if (dgv_products.Rows[i].Cells[2].Value != null)
                    {
                        if (dgv_products.Rows[i].Cells[2].Value.ToString() == true.ToString())
                        {
                            sql.Append($"identificator = {dgv_products.Rows[i].Cells[0].Value} ");
                        }

                        else
                        {
                            ViewAllBludos();
                           
                        }
                    }
                   
                }
                else { 
                if (dgv_products.Rows[i].Cells[2].Value != null) { 
                if (dgv_products.Rows[i].Cells[2].Value.ToString() == true.ToString())
                {
                    sql.Append($" or identificator = {dgv_products.Rows[i].Cells[0].Value} ");
                }

                else
                {
                    ViewAllBludos();
                  
                }
                }

                }

            }
            
            products = ProductFromDb.loadProductsOn(sql.ToString());
            dgv_products.DataSource = products;


        }

        private void btn_search_off_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder("SELECT * from bluda join products on products.identificator = bluda.identityb WHERE  ");
            int s = 0;
            for (int i = 0; i < dgv_products.RowCount - 1; i++)
            {
                if (i == 0)
                {
                    if (dgv_products.Rows[i].Cells[2].Value != null)
                    {
                        if (dgv_products.Rows[i].Cells[2].Value.ToString() == true.ToString())
                        {
                            sql.Append($"identificator != {dgv_products.Rows[i].Cells[0].Value} ");
                        }

                        else
                        {
                            ViewAllBludos();

                        }
                    }

                }
                else
                {
                    if (dgv_products.Rows[i].Cells[2].Value != null)
                    {
                        if (dgv_products.Rows[i].Cells[2].Value.ToString() == true.ToString())
                        {
                            sql.Append($" and identificator != {dgv_products.Rows[i].Cells[0].Value} ");
                        }

                        else
                        {
                            ViewAllBludos();

                        }
                    }

                }

            }

            products = ProductFromDb.loadProductsOn(sql.ToString());
            dgv_products.DataSource = products;
        }
    }
}
