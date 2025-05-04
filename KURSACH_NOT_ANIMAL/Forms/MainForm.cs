using KURSACH_NOT_ANIMAL.Classes.DbClasses;
using KURSACH_NOT_ANIMAL.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSACH_NOT_ANIMAL.Forms
{
    public partial class MainForm : Form
    {
        public static UserSystem CurrentUser { get; set; } = default!;

        public MainForm(UserSystem currentUser)
        {
            CurrentUser = currentUser;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!UserFromDb.CheckRoleAcess(CurrentUser.Id, "Администратор"))
                MENU_ADMIN.Visible = false;

            if (!UserFromDb.CheckRoleAcess(CurrentUser.Id, "Продавец"))
                MENU_WORK.Visible = false;
        }

        private void MENU_PROFILE_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(CurrentUser);
            profileForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => Program.StartForm.Show();

        private void MENU_ITEM_ANIMALS_Click(object sender, EventArgs e)
        {

        }
    }
}
