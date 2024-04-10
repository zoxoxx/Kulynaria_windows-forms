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
    public partial class ChangeRecept : Form
    {
        private int indexR;
        ReceptFromDB receptFromDB = new ReceptFromDB();

        public ChangeRecept()
        {
            InitializeComponent();
        }

        public ChangeRecept(int indexR, string text)
        {
            this.indexR = indexR;
            Text = text;
        }

        private void btn_changeRecept_Click(object sender, EventArgs e)
        {
            receptFromDB.ChangeRecept(tb_recept.Text, indexR);
        }

        private void ChangeRecept_Load(object sender, EventArgs e)
        {
            tb_recept.Text = Text;
        }
    }
}
