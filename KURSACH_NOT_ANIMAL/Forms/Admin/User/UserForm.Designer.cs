namespace KURSACH_NOT_ANIMAL.Forms.Admin
{
    partial class UserForm
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
            TB_PASSWORD = new TextBox();
            label7 = new Label();
            TB_LOGIN = new TextBox();
            label6 = new Label();
            label5 = new Label();
            TB_PHONE = new TextBox();
            label4 = new Label();
            DATE_PICKER_BIRTHDAY = new DateTimePicker();
            TB_PATRONYMIC = new TextBox();
            TB_NAME = new TextBox();
            TB_LASTNAME = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BTN_ACTION = new Button();
            CMB_ROLE = new ComboBox();
            label8 = new Label();
            LBL_BALANCE = new Label();
            TB_BALANCE = new TextBox();
            SuspendLayout();
            // 
            // TB_PASSWORD
            // 
            TB_PASSWORD.Anchor = AnchorStyles.None;
            TB_PASSWORD.Location = new Point(379, 179);
            TB_PASSWORD.Name = "TB_PASSWORD";
            TB_PASSWORD.Size = new Size(125, 27);
            TB_PASSWORD.TabIndex = 30;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(252, 186);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 29;
            label7.Text = "Пароль";
            // 
            // TB_LOGIN
            // 
            TB_LOGIN.Anchor = AnchorStyles.None;
            TB_LOGIN.Location = new Point(379, 140);
            TB_LOGIN.Name = "TB_LOGIN";
            TB_LOGIN.Size = new Size(125, 27);
            TB_LOGIN.TabIndex = 28;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(252, 143);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 27;
            label6.Text = "Логин";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Location = new Point(252, 222);
            label5.Name = "label5";
            label5.Size = new Size(79, 47);
            label5.TabIndex = 26;
            label5.Text = "Номер телефона";
            // 
            // TB_PHONE
            // 
            TB_PHONE.Anchor = AnchorStyles.None;
            TB_PHONE.Location = new Point(379, 219);
            TB_PHONE.Name = "TB_PHONE";
            TB_PHONE.Size = new Size(125, 27);
            TB_PHONE.TabIndex = 25;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(592, 144);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 24;
            label4.Text = "Дата рождения";
            // 
            // DATE_PICKER_BIRTHDAY
            // 
            DATE_PICKER_BIRTHDAY.Anchor = AnchorStyles.None;
            DATE_PICKER_BIRTHDAY.Location = new Point(520, 177);
            DATE_PICKER_BIRTHDAY.Name = "DATE_PICKER_BIRTHDAY";
            DATE_PICKER_BIRTHDAY.Size = new Size(250, 27);
            DATE_PICKER_BIRTHDAY.TabIndex = 23;
            // 
            // TB_PATRONYMIC
            // 
            TB_PATRONYMIC.Anchor = AnchorStyles.None;
            TB_PATRONYMIC.Location = new Point(107, 215);
            TB_PATRONYMIC.Name = "TB_PATRONYMIC";
            TB_PATRONYMIC.Size = new Size(125, 27);
            TB_PATRONYMIC.TabIndex = 22;
            // 
            // TB_NAME
            // 
            TB_NAME.Anchor = AnchorStyles.None;
            TB_NAME.Location = new Point(107, 179);
            TB_NAME.Name = "TB_NAME";
            TB_NAME.Size = new Size(125, 27);
            TB_NAME.TabIndex = 21;
            // 
            // TB_LASTNAME
            // 
            TB_LASTNAME.Anchor = AnchorStyles.None;
            TB_LASTNAME.Location = new Point(107, 146);
            TB_LASTNAME.Name = "TB_LASTNAME";
            TB_LASTNAME.Size = new Size(125, 27);
            TB_LASTNAME.TabIndex = 20;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(13, 215);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 19;
            label3.Text = "Отчество";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(13, 178);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 18;
            label2.Text = "Имя";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(12, 146);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 17;
            label1.Text = "Фамилия";
            // 
            // BTN_ACTION
            // 
            BTN_ACTION.Location = new Point(324, 339);
            BTN_ACTION.Name = "BTN_ACTION";
            BTN_ACTION.Size = new Size(162, 48);
            BTN_ACTION.TabIndex = 31;
            BTN_ACTION.Text = "Изменить/Добавить";
            BTN_ACTION.UseVisualStyleBackColor = true;
            BTN_ACTION.Click += BTN_ACTION_Click;
            // 
            // CMB_ROLE
            // 
            CMB_ROLE.FormattingEnabled = true;
            CMB_ROLE.Location = new Point(619, 222);
            CMB_ROLE.Name = "CMB_ROLE";
            CMB_ROLE.Size = new Size(151, 28);
            CMB_ROLE.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(520, 225);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 33;
            label8.Text = "Роль";
            // 
            // LBL_BALANCE
            // 
            LBL_BALANCE.AutoSize = true;
            LBL_BALANCE.Location = new Point(13, 268);
            LBL_BALANCE.Name = "LBL_BALANCE";
            LBL_BALANCE.Size = new Size(58, 20);
            LBL_BALANCE.TabIndex = 34;
            LBL_BALANCE.Text = "Баланс";
            // 
            // TB_BALANCE
            // 
            TB_BALANCE.Location = new Point(107, 268);
            TB_BALANCE.Name = "TB_BALANCE";
            TB_BALANCE.Size = new Size(125, 27);
            TB_BALANCE.TabIndex = 35;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TB_BALANCE);
            Controls.Add(LBL_BALANCE);
            Controls.Add(label8);
            Controls.Add(CMB_ROLE);
            Controls.Add(BTN_ACTION);
            Controls.Add(TB_PASSWORD);
            Controls.Add(label7);
            Controls.Add(TB_LOGIN);
            Controls.Add(label6);
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
            Name = "UserForm";
            Text = "Пользователь";
            Load += UserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_PASSWORD;
        private Label label7;
        private TextBox TB_LOGIN;
        private Label label6;
        private Label label5;
        private TextBox TB_PHONE;
        private Label label4;
        private DateTimePicker DATE_PICKER_BIRTHDAY;
        private TextBox TB_PATRONYMIC;
        private TextBox TB_NAME;
        private TextBox TB_LASTNAME;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BTN_ACTION;
        private ComboBox CMB_ROLE;
        private Label label8;
        private Label LBL_BALANCE;
        private TextBox TB_BALANCE;
    }
}