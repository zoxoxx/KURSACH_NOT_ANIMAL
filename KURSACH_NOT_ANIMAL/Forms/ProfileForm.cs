using KURSACH_NOT_ANIMAL.Classes.DbClasses;
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

namespace KURSACH_NOT_ANIMAL.Forms
{
    public partial class ProfileForm : Form
    {
        UserSystem ChangedUser { get; set; }
        public ProfileForm(UserSystem currentUser)
        {
            this.ChangedUser = currentUser;
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            string[] PHYO = ChangedUser.PHYO.Trim().Split(" ");
            TB_LASTNAME.Text = PHYO[0];
            TB_NAME.Text = PHYO[1];

            if (PHYO.Length > 2)
                TB_PATRONYMIC.Text = PHYO[2];

            DATE_PICKER_BIRTHDAY.Value = ChangedUser.Birthday.ToDateTime(TimeOnly.MinValue);
            TB_PHONE.Text = ChangedUser.Phone;
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
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

            if (DATE_PICKER_BIRTHDAY is null || DATE_PICKER_BIRTHDAY.Value == DateTime.Now)
            {
                MessageBox.Show("Необходимо указать дату рождения.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Хотите изменить профиль?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
                return;

            ChangedUser.Birthday = DateOnly.FromDateTime(DATE_PICKER_BIRTHDAY.Value);
            ChangedUser.PHYO = (TB_LASTNAME.Text.Trim() + " " + TB_NAME.Text.Trim() +
                (string.IsNullOrWhiteSpace(TB_PATRONYMIC.Text) ? "" : " " + TB_PATRONYMIC.Text.Trim())).Trim();
            ChangedUser.Phone = TB_PHONE.Text;

            if(!UserFromDb.UpdateUser(ChangedUser))
                return;

            MessageBox.Show($"{ChangedUser.PHYO}, профиль успешно обновлён.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }
    }
}
