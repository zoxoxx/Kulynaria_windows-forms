using Kulynaria_Altashev.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kulynaria_Altashev.Model;

namespace Kulynaria_Altashev.Forms
{
    public partial class UsersForm : Form
    {
        List<User> users = new List<User>();
        List<Role> roles = new List<Role>();
        int index = 0;
        Role role;
        public UsersForm()
        {
            InitializeComponent();
            cb_roles.DisplayMember = "RoleName";
            dgv_users.Columns[0].DataPropertyName = "UserId";
            dgv_users.Columns[1].DataPropertyName = "FirstName";
            dgv_users.Columns[2].DataPropertyName = "Patronymic";
            dgv_users.Columns[3].DataPropertyName = "LastName";
            dgv_users.Columns[4].DataPropertyName = "RoleId";
        }

        private void dgv_users_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = dgv_users.SelectedRows[0].Index;
            tb_name.Text = users[index].FirstName;
            tb_otchestvo_users.Text = users[index].Patronymic;
            tb_fm_users.Text = users[index].LastName;
            dtp_date.Value = users[index].DateOfBirthday;
            tb_phone.Text = users[index].Phone;
            tb_adress_users.Text = users[index].Adress;

            cb_roles.SelectedIndex = users[index].RoleId - 1;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
           users = UserFromDb.loadUsers();
            dgv_users.DataSource = users;


            roles = UserFromDb.loadRoles();
            cb_roles.DataSource = roles;
        }

        private void btn_delete_users_Click(object sender, EventArgs e)
        {
            UserFromDb.DeleteUser(users[index].UserId);
            users = UserFromDb.loadUsers();
            dgv_users.DataSource = users;
        }

        private void btn_add_users_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
            users = UserFromDb.loadUsers();
            dgv_users.DataSource = users;
        }

        private void btn_changerole_Click(object sender, EventArgs e)
        {
            int role_id = cb_roles.SelectedIndex + 1;
            UserFromDb.ChangeRole(users[index].UserId, role_id);
            users = UserFromDb.loadUsers();
            dgv_users.DataSource = users;
        }
    }
}
