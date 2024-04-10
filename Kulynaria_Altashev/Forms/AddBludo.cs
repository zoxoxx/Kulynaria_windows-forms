using Kulynaria_Altashev.Classes;
using Kulynaria_Altashev.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kulynaria_Altashev.Forms
{
    public partial class AddBludo : Form
    {
        string picFileName = "picture.jpg";
        ProductFromDb productsFromDB = new ProductFromDb();
        BludaFromDB bludaFromDB = new BludaFromDB();
        OsnovaFromDB osnovaFromDB = new OsnovaFromDB();
        public AddBludo()
        {
            InitializeComponent();
            pbBludo.SizeMode=PictureBoxSizeMode.StretchImage;
            pbBludo.Image = Image.FromFile(@"..\..\Images\picture.jpg");

        }

        private void cmbCat_load()
        {
            cmb_kat.DataSource = MainForm.categories;
            cmb_kat.DisplayMember = "vids_blud";
            cmb_kat.ValueMember = "Identityb";
        }

        private void cmbProduct_load()
        {
            cmbProduct.DataSource = ProductFromDb.loadProducts();
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "Id";
        }
        private void cmbOsn_load()
        {
           
            cmb_osn.DataSource = OsnovaFromDB.loadOsnovas();
            cmb_osn.DisplayMember = "Osnovaa";
            
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                picFileName = Path.GetFileName(openFileDialog.FileName);
                string distinPath = @"..\..\Images\" + picFileName;
                if (!File.Exists(distinPath)) 
                {
                    fileInfo.CopyTo(distinPath);
                }
                pbBludo.Image = Image.FromFile(distinPath);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
         if (!DublicateRows(cmbProduct.Text))
            {
                dgvSostavBluda.Rows.Add(cmbProduct.Text, tbWeightProd.Text);
            }
        }

        private bool DublicateRows(string selectProduct) 
        {
            bool isDublicate = false;

            for (int i = 0; i < dgvSostavBluda.RowCount-1; i++)
            {
                if (dgvSostavBluda.Rows[i].Cells[0].Value.ToString() == selectProduct)
                {
                    isDublicate = true;
                    MessageBox.Show("Такой продукт уже есть в списке!");
                    break;
                }
            }
            return isDublicate;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dgvSostavBluda.SelectedRows != null)
            {
                dgvSostavBluda.Rows.RemoveAt(dgvSostavBluda.CurrentRow.Index);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string picPath = @"..\..\Images\" + picFileName;

            Bludo newBludo = new Bludo(0, tb_BludoName.Text, cmb_kat.Text,cmb_osn.Text,Convert.ToInt32(tbWeightProd.Text), picPath);
            List<SostavBluda> sostavBl = new List<SostavBluda>();
            for (int i = 0; i < dgvSostavBluda.RowCount-1; i++)
            {
                sostavBl.Add(new SostavBluda(0, dgvSostavBluda.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(dgvSostavBluda.Rows[i].Cells[1].Value)));
            }

            bludaFromDB.AddNewBludo(newBludo, sostavBl, (int)cmb_kat.SelectedValue, picPath);
        }

        private void AddBludo_Load(object sender, EventArgs e)
        {
            cmbCat_load();
            cmbProduct_load();
            cmbOsn_load();
        }
    }
}
