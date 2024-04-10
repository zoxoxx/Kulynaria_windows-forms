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
    public partial class AuthorizationForm : Form
    {
       int counter = 0;
        UserFromDb userFromDb = new UserFromDb();
        public static User currentUser { get; set; } = null;
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void btn_vhod_Click(object sender, EventArgs e)
        {
            if (!(tb_login.Text != "" && tb_password.Text != ""))
            {
                MessageBox.Show("Введите данные"); return;
            }
            else
            {
                currentUser = userFromDb.GetUser(tb_login.Text, tb_password.Text);
                if(currentUser != null)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    counter++;
                    MessageBox.Show("Нет такого пользователя"); 
                    if (counter==4)
                    {
                        CaptchaForm captchaForm = new CaptchaForm();
                        DialogResult res = captchaForm.ShowDialog();
                    }
                    if (counter>5)
                    {
                        counter = 0;
                        counter++;
                    }
                }
            }
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
        }
    }
}
