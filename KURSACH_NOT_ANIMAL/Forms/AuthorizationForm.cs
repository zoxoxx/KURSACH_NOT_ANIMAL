using KURSACH_NOT_ANIMAL.Classes.DbClasses;
using KURSACH_NOT_ANIMAL.Classes.SystemClasses;
using KURSACH_NOT_ANIMAL.Forms;
using KURSACH_NOT_ANIMAL.Model;
using System.Text.RegularExpressions;

namespace KURSACH_NOT_ANIMAL
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void BTN_AUTORIZE_Click(object sender, EventArgs e)
        {
            if ((TB_LOGIN.Text is null || TB_LOGIN.Text == "") || (TB_PASSWORD.Text is null || TB_PASSWORD.Text == ""))
            {
                MessageBox.Show("Заполните логин и пароль.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserSystem? currentUser = UserFromDb.GetUser(TB_LOGIN.Text, TB_PASSWORD.Text);

            if (currentUser is null)
                return;

            MainForm mainForm = new MainForm(currentUser);
            mainForm.Show();
            this.Hide();
        }

        private void LINK_REGISTRATION_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrattionForm = new RegistrationForm();
            registrattionForm.ShowDialog();

            if (registrattionForm.NewUser is null)
                return;

            TB_LOGIN.Text = registrattionForm.NewUser.Login;
            TB_PASSWORD.Text = registrattionForm.NewUser.Password;

            MessageBox.Show("Регистрация успешно выполнена.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
