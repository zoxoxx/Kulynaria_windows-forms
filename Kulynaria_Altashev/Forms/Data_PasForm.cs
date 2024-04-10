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
using Kulynaria_Altashev.Classes;

namespace Kulynaria_Altashev.Forms
{
    public partial class Data_PasForm : Form
    {
        public Data_PasForm()
        {
            InitializeComponent();
        }

        private void btn_SavePas_Click(object sender, EventArgs e)
        {
            if (tb_OldPas.Text == "" || tb_NewPas.Text == "" || tb_PodNewPas.Text == "")
            { MessageBox.Show("Какое-то из полей не заполнено"); return; }
            string oldpassword = tb_OldPas.Text;
            string newpassword = tb_NewPas.Text;
            string pasRepeat = tb_PodNewPas.Text;
        
            bool flagPod = UserFromDb.CheckPassword(tb_NewPas.Text, tb_PodNewPas.Text);
            if (!flagPod) return;
            else
            {
                UserFromDb.GetPassword(tb_NewPas.Text, tb_OldPas.Text,  AuthorizationForm.currentUser);
                this.Hide();
            }

        }
    }
}
