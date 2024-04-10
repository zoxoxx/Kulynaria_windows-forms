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
    public partial class MainForm : Form
    {
        public List<Bludo> bludos = new List<Bludo>();
        BludaFromDB bludaFromDB = new BludaFromDB();
        public static List<Categoriya> categories = new List<Categoriya>();
        CategoriyaFromDB categoriyaFromDB = new CategoriyaFromDB();
        int flag = 0;
        int selectedRowIndex;
        List<SostavBluda> sostavBlud = new List<SostavBluda>();
      

        public MainForm()
        {
            InitializeComponent();
            dataGridView1.Columns[0].DataPropertyName = "Identityb";
            dataGridView1.Columns[1].DataPropertyName = "Bludo_image";
            dataGridView1.Columns[2].DataPropertyName = "bludo";
            dataGridView1.Columns[3].DataPropertyName = "Numbo";
            dataGridView1.Columns[4].DataPropertyName = "Osnova";
            dataGridView1.Columns[5].DataPropertyName = "Vyhod";
            dataGridView1.Columns[0].Visible = false;



        }

        void PrintSostavBluda(List<SostavBluda> sostavBludas, string bludoName)
        {
            ClearSostavBluda();

            lbl_bludoName.Text = bludoName;

            foreach(SostavBluda sostavBl in sostavBludas)
            {
                listBox_SostavBluda.Items.Add(sostavBl.ProductName + ", " + sostavBl.Weight);
            }

          
        }

        void ClearSostavBluda()
        {
            listBox_SostavBluda.Items.Clear();
            lbl_bludoName.Text = "";
        }




        private void ViewAllBludos()
        {
            bludos = bludaFromDB.loadBludos();
            dataGridView1.DataSource = bludos;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ViewAllBludos();

            categories = categoriyaFromDB.LoadCategories();
            categories.Insert(0, new Categoriya(0, "All"));
            comboBox1.DataSource = categories;

            comboBox1.DisplayMember = "vids_blud";
            comboBox1.ValueMember = "Identityb";

            switch (AuthorizationForm.currentUser.RoleId)
            {

                case 2:
                    добавитьБлюдоToolStripMenuItem.Visible = false;
                    удалитьБлюдоToolStripMenuItem.Visible = false;
                    пользователиToolStripMenuItem.Visible = false;
                    break;
                case 3:
                    добавитьПродуктToolStripMenuItem.Visible = false;
                    пользователиToolStripMenuItem.Visible = false;
                    break;
            }
            fIOToolStripMenuItem.Text = AuthorizationForm.currentUser.FirstName + " " + AuthorizationForm.currentUser.LastName;
            lb_counter.Text = dataGridView1.Rows.Count.ToString() + " из " + BludaFromDB.CounterBludos().ToString();
            gb_sostav.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) 
            {
                ViewAllBludos();
            }

            else
            {
                flag = 1;
                bludos = bludaFromDB.FiltrBludosByCategory(Convert.ToInt32(comboBox1.SelectedValue));
                dataGridView1.DataSource = bludos;
            }
        }                    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            flag = 2;
            dataGridView1.DataSource = SearchBludos(textBox1.Text);
            lb_counter.Text = dataGridView1.Rows.Count.ToString() + " из " + BludaFromDB.CounterBludos().ToString();

        }
        private List<Bludo> SearchBludos(string txbSearch)
        {
            List<Bludo> bludoSearch = new List<Bludo>();

            foreach (Bludo item in bludos)
            {
                if (item.bludo.StartsWith(txbSearch) || item.Osnova.StartsWith(txbSearch)) 
                {
                    bludoSearch.Add(item);
                }
            }
            return bludoSearch;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gb_sostav.Visible = true;
            flag = 0;
            selectedRowIndex = dataGridView1.CurrentRow.Index;
            sostavBlud = bludaFromDB.SostavBludFromDB(bludos[selectedRowIndex].Identityb);
            PrintSostavBluda(sostavBlud, bludos[selectedRowIndex].bludo);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2)
            {
                ClearSostavBluda();
            }
        }

        private void добавитьБлюдоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBludo addblud1 = new AddBludo();
            this.Hide();
            addblud1.ShowDialog();
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationForm exi = new AuthorizationForm();
            this.Hide();
            exi.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void редактироватьПрофильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataForm vhod = new DataForm();
            this.Hide();
            DialogResult result = vhod.ShowDialog();
            if (result == DialogResult.OK) 
            {
                fIOToolStripMenuItem.Text = AuthorizationForm.currentUser.FirstName + " " + AuthorizationForm.currentUser.LastName;
            }

        }

        private void сменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_PasForm vhod2 = new Data_PasForm();
            vhod2.ShowDialog();
            this.Hide();
            
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usersss = new UsersForm();
            this.Hide();
            usersss.ShowDialog();
        }

        private void добавитьПродуктToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductForm add = new AddProductForm();
            this.Hide();
            add.ShowDialog();
        }

        private void иToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_SearchForm forrmn = new Delete_SearchForm();
            this.Hide();
            forrmn.ShowDialog();
        }

        private void рецептыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceptForm voiti = new ReceptForm();
            this.Hide();
            voiti.ShowDialog();
        }

        private void поискПоКритериямToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
