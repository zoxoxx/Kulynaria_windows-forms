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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btn_reg_pod_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "" || tb_fm.Text == "" || tb_log.Text == "" || tb_pas.Text == "" || tb_pod_pas.Text == "")
            { MessageBox.Show("Необходимо заполнить все поля!"); return; }
            bool rez = UserFromDb.CheckPassword(tb_pas.Text, tb_pod_pas.Text);
            if (!rez) return;
            else
                if (UserFromDb.CheckUser(tb_log.Text))
            {
                UserFromDb.UserAdd(tb_log.Text, tb_pas.Text, tb_name.Text, tb_fm.Text);
            }
            else return;
            this.Hide();
        }
    }
}
