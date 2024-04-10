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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void btn_newProduct_Click(object sender, EventArgs e)
        {
            ProductFromDb.ProductAdd(tb_nameBludo.Text, tb_belki.Text, tb_zhire.Text, tb_uglev.Text);
            Delete_SearchForm bl = new Delete_SearchForm();
            this.Hide();
            bl.ShowDialog();
        }
    }
}
