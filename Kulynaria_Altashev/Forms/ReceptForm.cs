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
    public partial class ReceptForm : Form
    {
        List <Bludo> bludos = new List <Bludo> ();
        BludaFromDB bludaFromDB = new BludaFromDB();
        List<SostavBluda> sostavBlud = new List<SostavBluda>();
        List <Recept> recepts = new List <Recept> ();
        ReceptFromDB receptFromDB = new ReceptFromDB ();
        int selectedRowIndex = 0;
        int indexMetod;
        int indexR = 0;
        int id_bluda = 1;
        public ReceptForm()
        {
            InitializeComponent();
        }

        private void ReceptForm_Load(object sender, EventArgs e)
        {
            ViewAllBludos();
            indexMetod = bludaFromDB.Schetchik(bludos);
            PrintSostav(sostavBlud, bludos[selectedRowIndex].bludo);
            PrintR();
           
            btn_nazad.Enabled = false;
        }
        private void ViewAllBludos()
        {
            bludos = bludaFromDB.loadBludos();
            recepts = receptFromDB.loadRecepts();
        }
        void PrintSostav(List<SostavBluda> sostavBludas, string bludoName)
        {
            Clear();
            sostavBlud = bludaFromDB.SostavBludFromDB(id_bluda);
            label_bludoname.Text = bludoName;
            foreach(SostavBluda sostavBl in sostavBlud)
            {
                ListBox_sostavBl.Items.Add(sostavBl.ProductName + ", " + sostavBl.Weight);
            }
        }
        void PrintR ()
        {
            tb_recept.Text = recepts[indexR].Recept_Name;
        }
        void Clear()
        {
            ListBox_sostavBl.Items.Clear();
            label_bludoname.Text = "";
        }
        void del()
        {
            receptFromDB.DeleteRecept(id_bluda);
        }
        //add recept
        private void btn_add_Click(object sender, EventArgs e)
        {if (recepts[indexR] == null)
            {
                AddRecept voit = new AddRecept();
                this.Hide();
                voit.ShowDialog();
            }
        else
            {
                MessageBox.Show("У этого блюда уже есть рецепт");
            }
         
        }
        //edit recept
        private void btn_edit_Click(object sender, EventArgs e)
        {
            
                if (recepts[indexR] == null)
                {
                    ChangeRecept voit = new ChangeRecept(indexR,tb_recept.Text);
                    this.Hide();
                    voit.ShowDialog();
                }
                else
                {
                    MessageBox.Show("У этого блюда нет рецепта, создайте его");
                }

            }

        private void btn_nazad_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex == 0)
            {
                btn_nazad.Enabled = false;
            }
            else if (selectedRowIndex < indexMetod && selectedRowIndex >=0)
            {
                selectedRowIndex--;
                indexR--;
                id_bluda--;
                PrintSostav(sostavBlud, bludos[selectedRowIndex].bludo);
                PrintR();
            }
        }

        private void btn_vpered_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < indexMetod && selectedRowIndex>=0)
            {
                btn_nazad.Enabled = true;
                selectedRowIndex++;
                indexR++;
                id_bluda++;
                PrintSostav(sostavBlud, bludos[selectedRowIndex].bludo);
                PrintR();
            }
            else if (selectedRowIndex ==  indexMetod) 
            {
                btn_vpered.Enabled = false;
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            del();
        }
    }
}
