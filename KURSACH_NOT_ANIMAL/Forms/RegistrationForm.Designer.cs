namespace KURSACH_NOT_ANIMAL.Forms
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TB_LASTNAME = new TextBox();
            TB_NAME = new TextBox();
            TB_PATRONYMIC = new TextBox();
            DATE_PICKER_BIRTHDAY = new DateTimePicker();
            TB_PHONE = new TextBox();
            BTN_REGISTRATION = new Button();
            TB_LOGIN = new TextBox();
            TB_PASSWORD = new TextBox();
            TB_REPEAT_PASSWORD = new TextBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TB_LASTNAME
            // 
            TB_LASTNAME.Anchor = AnchorStyles.None;
            TB_LASTNAME.Font = new Font("Segoe UI", 10F);
            TB_LASTNAME.Location = new Point(250, 91);
            TB_LASTNAME.Margin = new Padding(4);
            TB_LASTNAME.Name = "TB_LASTNAME";
            TB_LASTNAME.PlaceholderText = "Фамилия";
            TB_LASTNAME.Size = new Size(189, 34);
            TB_LASTNAME.TabIndex = 3;
            // 
            // TB_NAME
            // 
            TB_NAME.Anchor = AnchorStyles.None;
            TB_NAME.Font = new Font("Segoe UI", 10F);
            TB_NAME.Location = new Point(250, 141);
            TB_NAME.Margin = new Padding(4);
            TB_NAME.Name = "TB_NAME";
            TB_NAME.PlaceholderText = "Имя";
            TB_NAME.Size = new Size(189, 34);
            TB_NAME.TabIndex = 4;
            // 
            // TB_PATRONYMIC
            // 
            TB_PATRONYMIC.Anchor = AnchorStyles.None;
            TB_PATRONYMIC.Font = new Font("Segoe UI", 10F);
            TB_PATRONYMIC.Location = new Point(250, 192);
            TB_PATRONYMIC.Margin = new Padding(4);
            TB_PATRONYMIC.Name = "TB_PATRONYMIC";
            TB_PATRONYMIC.PlaceholderText = "Отчество";
            TB_PATRONYMIC.Size = new Size(189, 34);
            TB_PATRONYMIC.TabIndex = 5;
            // 
            // DATE_PICKER_BIRTHDAY
            // 
            DATE_PICKER_BIRTHDAY.Anchor = AnchorStyles.None;
            DATE_PICKER_BIRTHDAY.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DATE_PICKER_BIRTHDAY.Location = new Point(218, 258);
            DATE_PICKER_BIRTHDAY.Margin = new Padding(4);
            DATE_PICKER_BIRTHDAY.Name = "DATE_PICKER_BIRTHDAY";
            DATE_PICKER_BIRTHDAY.Size = new Size(221, 31);
            DATE_PICKER_BIRTHDAY.TabIndex = 6;
            // 
            // TB_PHONE
            // 
            TB_PHONE.Anchor = AnchorStyles.None;
            TB_PHONE.Font = new Font("Segoe UI", 10F);
            TB_PHONE.Location = new Point(33, 319);
            TB_PHONE.Margin = new Padding(4);
            TB_PHONE.Name = "TB_PHONE";
            TB_PHONE.PlaceholderText = "Номер телефона";
            TB_PHONE.Size = new Size(406, 34);
            TB_PHONE.TabIndex = 8;
            TB_PHONE.TextChanged += TB_PHONE_TextChanged;
            TB_PHONE.KeyDown += TB_PHONE_KeyDown;
            // 
            // BTN_REGISTRATION
            // 
            BTN_REGISTRATION.Anchor = AnchorStyles.None;
            BTN_REGISTRATION.BackColor = SystemColors.ActiveBorder;
            BTN_REGISTRATION.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_REGISTRATION.Location = new Point(33, 384);
            BTN_REGISTRATION.Margin = new Padding(4);
            BTN_REGISTRATION.Name = "BTN_REGISTRATION";
            BTN_REGISTRATION.Size = new Size(406, 68);
            BTN_REGISTRATION.TabIndex = 10;
            BTN_REGISTRATION.Text = "Зарегистрироваться";
            BTN_REGISTRATION.UseVisualStyleBackColor = false;
            BTN_REGISTRATION.Click += BTN_REGISTRATION_Click;
            // 
            // TB_LOGIN
            // 
            TB_LOGIN.Anchor = AnchorStyles.None;
            TB_LOGIN.Font = new Font("Segoe UI", 10F);
            TB_LOGIN.Location = new Point(33, 91);
            TB_LOGIN.Margin = new Padding(4);
            TB_LOGIN.Name = "TB_LOGIN";
            TB_LOGIN.PlaceholderText = "Логин";
            TB_LOGIN.Size = new Size(189, 34);
            TB_LOGIN.TabIndex = 12;
            // 
            // TB_PASSWORD
            // 
            TB_PASSWORD.Anchor = AnchorStyles.None;
            TB_PASSWORD.Font = new Font("Segoe UI", 10F);
            TB_PASSWORD.Location = new Point(33, 140);
            TB_PASSWORD.Margin = new Padding(4);
            TB_PASSWORD.Name = "TB_PASSWORD";
            TB_PASSWORD.PasswordChar = '*';
            TB_PASSWORD.PlaceholderText = "Пароль";
            TB_PASSWORD.Size = new Size(189, 34);
            TB_PASSWORD.TabIndex = 14;
            // 
            // TB_REPEAT_PASSWORD
            // 
            TB_REPEAT_PASSWORD.Anchor = AnchorStyles.None;
            TB_REPEAT_PASSWORD.Font = new Font("Segoe UI", 10F);
            TB_REPEAT_PASSWORD.Location = new Point(33, 192);
            TB_REPEAT_PASSWORD.Margin = new Padding(4);
            TB_REPEAT_PASSWORD.Name = "TB_REPEAT_PASSWORD";
            TB_REPEAT_PASSWORD.PasswordChar = '*';
            TB_REPEAT_PASSWORD.PlaceholderText = "Подтверждение";
            TB_REPEAT_PASSWORD.Size = new Size(189, 34);
            TB_REPEAT_PASSWORD.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(DATE_PICKER_BIRTHDAY);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TB_PASSWORD);
            panel1.Controls.Add(BTN_REGISTRATION);
            panel1.Controls.Add(TB_REPEAT_PASSWORD);
            panel1.Controls.Add(TB_PHONE);
            panel1.Controls.Add(TB_LOGIN);
            panel1.Controls.Add(TB_NAME);
            panel1.Controls.Add(TB_LASTNAME);
            panel1.Controls.Add(TB_PATRONYMIC);
            panel1.Location = new Point(229, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 491);
            panel1.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(33, 257);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Дата рождения";
            textBox1.Size = new Size(406, 34);
            textBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(98, 10);
            label1.Name = "label1";
            label1.Size = new Size(276, 60);
            label1.TabIndex = 16;
            label1.Text = "Регистрация";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 544);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox TB_LASTNAME;
        private TextBox TB_NAME;
        private TextBox TB_PATRONYMIC;
        private DateTimePicker DATE_PICKER_BIRTHDAY;
        private TextBox TB_PHONE;
        private Button BTN_REGISTRATION;
        private TextBox TB_LOGIN;
        private TextBox TB_PASSWORD;
        private TextBox TB_REPEAT_PASSWORD;
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
    }
}