using KURSACH_NOT_ANIMAL.Classes.DbClasses;
using KURSACH_NOT_ANIMAL.Classes.ViewClasses;
using KURSACH_NOT_ANIMAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSACH_NOT_ANIMAL.Forms.Admin
{
    public partial class UserForm : Form
    {
        private bool? flagInsert;
        private bool? flagUpdate;
        private UserView? changedUser;
        private List<UserRole>? roles;
        public UserForm(bool? flagInsert = null, bool? flagUpdate = null, UserView? changedUser = null)
        {
            this.flagInsert = flagInsert;
            this.flagUpdate = flagUpdate;
            this.changedUser = changedUser;

            InitializeComponent();

            CMB_ROLE.DisplayMember = "Name";
            CMB_ROLE.ValueMember = "Id";
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            ComboBoxLoad();

            if (flagUpdate != null)
                BTN_ACTION.Text = "Изменить";

            if (flagInsert != null)
                BTN_ACTION.Text = "Добавить";

            if (changedUser != null && flagUpdate != null)
            {
                string[] phyo = changedUser.Phyo.Trim().Split(" ");

                TB_LASTNAME.Text = phyo[0];
                TB_NAME.Text = phyo[1];

                if (phyo.Length > 2)
                    TB_PATRONYMIC.Text = phyo[2];

                TB_PHONE.Text = changedUser.Phone;
                DATE_PICKER_BIRTHDAY.Value = changedUser.Birthday.ToDateTime(TimeOnly.MinValue);
                TB_LOGIN.Text = changedUser.Login;
                TB_PASSWORD.Text = changedUser.Password;

                if (changedUser.RoleName != "Администратор")
                    TB_BALANCE.Text = changedUser.Balance.ToString() ?? "0";
                else
                {
                    TB_BALANCE.Text = "0";
                    TB_BALANCE.Visible = false;
                }
                CMB_ROLE.SelectedValue = changedUser.RoleId;
            }
        }

        private void ComboBoxLoad()
        {
            roles = UserFromDb.GetRoles();
            CMB_ROLE.DataSource = roles;
        }

        private void BTN_ACTION_Click(object sender, EventArgs e)
        {
            if ((TB_LOGIN.Text is null || TB_LOGIN.Text == "") || (TB_PASSWORD.Text is null || TB_PASSWORD.Text == ""))
            {
                MessageBox.Show("Заполните логин и пароль.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(TB_PASSWORD.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[\\W_]).{8,}$"))
            {
                MessageBox.Show("Пароль должен быть не менее 8 символов,\n" +
                    " иметь один специальный символ,\n" +
                    "буквы верхнего и нижнего регистров,\n" +
                    "и хотя бы одну цифру.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (TB_LASTNAME.Text is null || TB_LASTNAME.Text == "")
            {
                MessageBox.Show("Необходимо заполнить фамилию.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TB_NAME.Text is null || TB_NAME.Text == "")
            {
                MessageBox.Show("Необходимо заполнить имя.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TB_PHONE.Text is null || TB_PHONE.Text == "")
            {
                MessageBox.Show("Необходимо заполнить номер телефона.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TB_PHONE.Text.Length > 11 || TB_PHONE.Text.Length < 11)
            {
                MessageBox.Show("Длина номера мобильного телефона должна составлять 11 знаков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double balance;
            if (!double.TryParse(TB_BALANCE.Text, out balance) || balance < 0)
            {
                MessageBox.Show("Баланс должен быть заполнен только числами и не меньше 0.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DATE_PICKER_BIRTHDAY is null || DATE_PICKER_BIRTHDAY.Value == DateTime.Now)
            {
                MessageBox.Show("Необходимо указать дату рождения.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CMB_ROLE.SelectedValue is null)
            {
                MessageBox.Show("Необходимо заполнить роль.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (flagInsert != null)
            {
                int result = UserFromDb.AddUserWithRole(TB_LOGIN.Text, TB_PASSWORD.Text,
                    DateOnly.FromDateTime(DATE_PICKER_BIRTHDAY.Value), TB_PHONE.Text,
                    TB_LASTNAME.Text.Trim() + " " + TB_NAME.Text.Trim() + (string.IsNullOrEmpty(TB_PATRONYMIC.Text.Trim()) ? "" : " " + TB_PATRONYMIC.Text.Trim()),
                    Convert.ToInt32(CMB_ROLE.SelectedValue));

                if (result == 1)
                    MessageBox.Show("Пользователь успешно добавлен.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (flagUpdate != null && changedUser != null)
            {
                bool result = UserFromDb.UpdateUser(new UserSystem(
                    changedUser.Id, Convert.ToInt32(CMB_ROLE.SelectedValue),
                    TB_LASTNAME.Text.Trim() + " " + TB_NAME.Text.Trim() + (string.IsNullOrEmpty(TB_PATRONYMIC.Text.Trim()) ? "" : " " + TB_PATRONYMIC.Text.Trim()),
                    DateOnly.FromDateTime(DATE_PICKER_BIRTHDAY.Value), TB_PHONE.Text, Convert.ToDouble(TB_BALANCE.Text), TB_LOGIN.Text, TB_PASSWORD.Text));

                if (result)
                    MessageBox.Show("Пользователь успешно обновлен.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }
    }
}
