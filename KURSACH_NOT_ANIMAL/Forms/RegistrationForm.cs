using KURSACH_NOT_ANIMAL.Classes.DbClasses;
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

namespace KURSACH_NOT_ANIMAL.Forms
{
    public partial class RegistrationForm : Form
    {
        internal UserSystem? NewUser { get; set; } = null;
        string digits = "";
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void BTN_REGISTRATION_Click(object sender, EventArgs e)
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

            if (TB_PASSWORD.Text != TB_REPEAT_PASSWORD.Text)
            {
                MessageBox.Show("Пароли не совпадают.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (digits.Length > 11 || digits.Length < 11)
            {
                MessageBox.Show("Длина номера мобильного телефона должна составлять 11 знаков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DATE_PICKER_BIRTHDAY is null || DATE_PICKER_BIRTHDAY.Value == DateTime.Now)
            {
                MessageBox.Show("Необходимо указать дату рождения.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int result = UserFromDb.AddUser(TB_LOGIN.Text, TB_PASSWORD.Text, DateOnly.FromDateTime(DATE_PICKER_BIRTHDAY.Value), digits,
                (TB_LASTNAME.Text.Trim() + " " + TB_NAME.Text.Trim() +
                (string.IsNullOrWhiteSpace(TB_PATRONYMIC.Text) ? "" : " " + TB_PATRONYMIC.Text.Trim())).Trim());

            if (result == 1)
                NewUser = new UserSystem(TB_LASTNAME.Text.Trim() + " " + TB_NAME.Text.Trim() + (string.IsNullOrEmpty(TB_PATRONYMIC.Text.Trim()) ? "" : " " + TB_PATRONYMIC.Text.Trim()),
                    DateOnly.FromDateTime(DATE_PICKER_BIRTHDAY.Value), digits, 0, TB_LOGIN.Text, TB_PASSWORD.Text);

            this.Close();
        }

        private void TB_PHONE_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (e.KeyCode == Keys.Back)
            {
                if (digits.Length > 0)
                {
                    digits = digits.Substring(0, digits.Length - 1);

                    string formatted = FormatPhoneNumber();

                    tb.TextChanged -= TB_PHONE_TextChanged;
                    tb.Text = formatted;
                    tb.SelectionStart = tb.Text.Length;
                    tb.TextChanged += TB_PHONE_TextChanged;
                }

                e.SuppressKeyPress = true;
            }
        }

        private void TB_PHONE_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            string currentDigits = System.Text.RegularExpressions.Regex.Replace(tb.Text, @"\D", "");
            if (currentDigits.Length > digits.Length)
            {
                string added = currentDigits.Substring(digits.Length);
                digits += System.Text.RegularExpressions.Regex.Replace(added, @"\D", "");
            }

            if (digits.Length > 11)
                digits = digits.Substring(0, 11);

            string formatted = FormatPhoneNumber();

            tb.TextChanged -= TB_PHONE_TextChanged;
            tb.Text = formatted;
            tb.SelectionStart = tb.Text.Length;
            tb.TextChanged += TB_PHONE_TextChanged;
        }

        private string FormatPhoneNumber()
        {
            if (string.IsNullOrEmpty(digits))
                return "";

            if (digits.StartsWith("8"))
                digits = "7" + digits.Substring(1);
            else if (!digits.StartsWith("7"))
                digits = "7" + digits;

            string formatted = "+";

            for (int i = 0; i < digits.Length; i++)
            {
                switch (i)
                {
                    case 0: formatted += digits[i] + " "; break;
                    case 1: formatted += "(" + digits[i]; break;
                    case 3: formatted += digits[i] + ") "; break;
                    case 6: formatted += digits[i] + "-"; break;
                    case 8: formatted += digits[i] + "-"; break;
                    default: formatted += digits[i]; break;
                }
            }

            return formatted;
        }
    }
}
