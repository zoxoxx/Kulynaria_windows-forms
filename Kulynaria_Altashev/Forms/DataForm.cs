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
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            tb_NameUpdate.Text = AuthorizationForm.currentUser.FirstName;
            tb_FmUpdate.Text = AuthorizationForm.currentUser.LastName;
            tb_otchestvoUpdate.Text = AuthorizationForm.currentUser.Patronymic;
            dt_BirthdayUpdate.Value = AuthorizationForm.currentUser.DateOfBirthday;
            tb_phoneUpdate.Text = AuthorizationForm.currentUser.Phone;
            tb_AdressUpdate.Text = AuthorizationForm.currentUser.Adress;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(tb_NameUpdate.Text!="" && tb_FmUpdate.Text!= "")
            {
                AuthorizationForm.currentUser.FirstName = tb_NameUpdate.Text;
                AuthorizationForm.currentUser.LastName = tb_FmUpdate.Text;
                AuthorizationForm.currentUser.Patronymic = tb_otchestvoUpdate.Text;
                AuthorizationForm.currentUser.DateOfBirthday = dt_BirthdayUpdate.Value;
                AuthorizationForm.currentUser.Phone = tb_phoneUpdate.Text;
                AuthorizationForm.currentUser.Adress = tb_AdressUpdate.Text;

                UserFromDb.UserUpdateProfil(AuthorizationForm.currentUser);
            }
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
            
        }
    }
}
