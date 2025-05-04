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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TB_LASTNAME = new TextBox();
            TB_NAME = new TextBox();
            TB_PATRONYMIC = new TextBox();
            DATE_PICKER_BIRTHDAY = new DateTimePicker();
            label4 = new Label();
            TB_PHONE = new TextBox();
            label5 = new Label();
            BTN_REGISTRATION = new Button();
            label6 = new Label();
            TB_LOGIN = new TextBox();
            label7 = new Label();
            TB_PASSWORD = new TextBox();
            TB_REPEAT_PASSWORD = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(9, 142);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(10, 174);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(10, 211);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Отчество";
            // 
            // TB_LASTNAME
            // 
            TB_LASTNAME.Anchor = AnchorStyles.None;
            TB_LASTNAME.Location = new Point(104, 142);
            TB_LASTNAME.Name = "TB_LASTNAME";
            TB_LASTNAME.Size = new Size(125, 27);
            TB_LASTNAME.TabIndex = 3;
            // 
            // TB_NAME
            // 
            TB_NAME.Anchor = AnchorStyles.None;
            TB_NAME.Location = new Point(104, 175);
            TB_NAME.Name = "TB_NAME";
            TB_NAME.Size = new Size(125, 27);
            TB_NAME.TabIndex = 4;
            // 
            // TB_PATRONYMIC
            // 
            TB_PATRONYMIC.Anchor = AnchorStyles.None;
            TB_PATRONYMIC.Location = new Point(104, 211);
            TB_PATRONYMIC.Name = "TB_PATRONYMIC";
            TB_PATRONYMIC.Size = new Size(125, 27);
            TB_PATRONYMIC.TabIndex = 5;
            // 
            // DATE_PICKER_BIRTHDAY
            // 
            DATE_PICKER_BIRTHDAY.Anchor = AnchorStyles.None;
            DATE_PICKER_BIRTHDAY.Location = new Point(517, 173);
            DATE_PICKER_BIRTHDAY.Name = "DATE_PICKER_BIRTHDAY";
            DATE_PICKER_BIRTHDAY.Size = new Size(250, 27);
            DATE_PICKER_BIRTHDAY.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(589, 140);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 7;
            label4.Text = "Дата рождения";
            // 
            // TB_PHONE
            // 
            TB_PHONE.Anchor = AnchorStyles.None;
            TB_PHONE.Location = new Point(661, 213);
            TB_PHONE.Name = "TB_PHONE";
            TB_PHONE.Size = new Size(125, 27);
            TB_PHONE.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(517, 216);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 9;
            label5.Text = "Номер телефона";
            // 
            // BTN_REGISTRATION
            // 
            BTN_REGISTRATION.Anchor = AnchorStyles.None;
            BTN_REGISTRATION.Location = new Point(303, 364);
            BTN_REGISTRATION.Name = "BTN_REGISTRATION";
            BTN_REGISTRATION.Size = new Size(162, 29);
            BTN_REGISTRATION.TabIndex = 10;
            BTN_REGISTRATION.Text = "Зарегистрироваться";
            BTN_REGISTRATION.UseVisualStyleBackColor = true;
            BTN_REGISTRATION.Click += BTN_REGISTRATION_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(249, 139);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 11;
            label6.Text = "Логин";
            // 
            // TB_LOGIN
            // 
            TB_LOGIN.Anchor = AnchorStyles.None;
            TB_LOGIN.Location = new Point(376, 136);
            TB_LOGIN.Name = "TB_LOGIN";
            TB_LOGIN.Size = new Size(125, 27);
            TB_LOGIN.TabIndex = 12;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(249, 182);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 13;
            label7.Text = "Пароль";
            // 
            // TB_PASSWORD
            // 
            TB_PASSWORD.Anchor = AnchorStyles.None;
            TB_PASSWORD.Location = new Point(376, 175);
            TB_PASSWORD.Name = "TB_PASSWORD";
            TB_PASSWORD.Size = new Size(125, 27);
            TB_PASSWORD.TabIndex = 14;
            // 
            // TB_REPEAT_PASSWORD
            // 
            TB_REPEAT_PASSWORD.Anchor = AnchorStyles.None;
            TB_REPEAT_PASSWORD.Location = new Point(376, 216);
            TB_REPEAT_PASSWORD.Name = "TB_REPEAT_PASSWORD";
            TB_REPEAT_PASSWORD.Size = new Size(125, 27);
            TB_REPEAT_PASSWORD.TabIndex = 15;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.Location = new Point(248, 214);
            label8.Name = "label8";
            label8.Size = new Size(123, 92);
            label8.TabIndex = 16;
            label8.Text = "Подтверждение пароля";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(TB_REPEAT_PASSWORD);
            Controls.Add(TB_PASSWORD);
            Controls.Add(label7);
            Controls.Add(TB_LOGIN);
            Controls.Add(label6);
            Controls.Add(BTN_REGISTRATION);
            Controls.Add(label5);
            Controls.Add(TB_PHONE);
            Controls.Add(label4);
            Controls.Add(DATE_PICKER_BIRTHDAY);
            Controls.Add(TB_PATRONYMIC);
            Controls.Add(TB_NAME);
            Controls.Add(TB_LASTNAME);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TB_LASTNAME;
        private TextBox TB_NAME;
        private TextBox TB_PATRONYMIC;
        private DateTimePicker DATE_PICKER_BIRTHDAY;
        private Label label4;
        private TextBox TB_PHONE;
        private Label label5;
        private Button BTN_REGISTRATION;
        private Label label6;
        private TextBox TB_LOGIN;
        private Label label7;
        private TextBox TB_PASSWORD;
        private TextBox TB_REPEAT_PASSWORD;
        private Label label8;
    }
}