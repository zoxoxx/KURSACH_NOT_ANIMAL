using KURSACH_NOT_ANIMAL.Classes.ViewClasses;
using KURSACH_NOT_ANIMAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSACH_NOT_ANIMAL.Forms.Admin
{
    public partial class UserReestr : Form
    {
        private List<UserView>? users;
        public UserReestr()
        {
            InitializeComponent();

            DG_USERS.Columns[0].DataPropertyName = "Id";
            DG_USERS.Columns[1].DataPropertyName = "Phyo";
            DG_USERS.Columns[2].DataPropertyName = "RoleId";
            DG_USERS.Columns[3].DataPropertyName = "RoleName";
            DG_USERS.Columns[4].DataPropertyName = "Birthday";
            DG_USERS.Columns[5].DataPropertyName = "Phone";
            DG_USERS.Columns[6].DataPropertyName = "Balance";
            DG_USERS.Columns[7].DataPropertyName = "Login";
            DG_USERS.Columns[8].DataPropertyName = "Password";

            DG_USERS.AutoGenerateColumns = false;
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(flagInsert: true);
            this.Hide();
            userForm.ShowDialog();
            this.Show();

            DataGridLoad();
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            UserView? selectedUser = DG_USERS.CurrentRow.DataBoundItem as UserView;

            if (selectedUser is null)
                return;

            UserFromDb.DeleteUser(selectedUser.Id);
            DataGridLoad();
        }

        private void DataGridLoad()
        {
            users = UserFromDb.GetUsersWithRole();
            DG_USERS.DataSource = users;
        }

        private void DG_USERS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UserView? selectedUser = DG_USERS.CurrentRow.DataBoundItem as UserView;

            if (selectedUser is null)
                return;

            UserForm userForm = new UserForm(changedUser: selectedUser, flagUpdate: true);
            this.Hide();
            userForm.ShowDialog();
            this.Show();

            DataGridLoad();
        }

        private void UserReestr_Load(object sender, EventArgs e)
        {
            DataGridLoad();
        }
    }
}
