using KURSACH_NOT_ANIMAL.Classes.DbClasses;
using KURSACH_NOT_ANIMAL.Forms.Admin;
using KURSACH_NOT_ANIMAL.Forms.Admin.Shop;
using KURSACH_NOT_ANIMAL.Forms.Admin.Sklad;
using KURSACH_NOT_ANIMAL.Forms.Reestr;
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
            AnimalReestr animalReestr = new AnimalReestr();
            animalReestr.ShowDialog();
        }

        private void MENU_ITEM_USERS_Click(object sender, EventArgs e)
        {
            UserReestr userReestr = new UserReestr();
            userReestr.ShowDialog();
        }

        private void MENU_ITEM_PARTNERS_Click(object sender, EventArgs e)
        {
            ShopReestr shopReestr = new ShopReestr(flagPartner: true);
            this.Hide();
            shopReestr.ShowDialog();
            this.Show();
        }

        private void MENU_ITEM_SHOPS_Click(object sender, EventArgs e)
        {
            ShopReestr shopReestr = new ShopReestr(flagShop: true);
            this.Hide();
            shopReestr.ShowDialog();
            this.Show();
        }

        private void MENU_ITEM_SKLAD_Click(object sender, EventArgs e)
        {
            SkladReestr skladReestr = new SkladReestr();
            this.Hide();
            skladReestr.ShowDialog();
            this.Show();
        }

        private void MENU_ITEM_SCHEDULE_Click(object sender, EventArgs e)
        {
            ScheduleReestr scheduleReestr = new ScheduleReestr();
            this.Hide();
            scheduleReestr.ShowDialog();
            this.Show();
        }
    }
}
