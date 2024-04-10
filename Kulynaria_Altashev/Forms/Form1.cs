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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) 
            {
                ViewAllBludos();
            }

            else
            {
                bludos = bludaFromDB.FiltrBludosByCategory(Convert.ToInt32(comboBox1.SelectedValue));
                dataGridView1.DataSource = bludos;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SearchBludos(textBox1.Text);

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
    }
}
