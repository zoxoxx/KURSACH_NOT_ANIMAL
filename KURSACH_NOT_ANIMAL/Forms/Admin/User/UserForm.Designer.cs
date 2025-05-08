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
            TB_LOGIN = new TextBox();
            TB_PHONE = new TextBox();
            label4 = new Label();
            DATE_PICKER_BIRTHDAY = new DateTimePicker();
            TB_PATRONYMIC = new TextBox();
            TB_NAME = new TextBox();
            TB_LASTNAME = new TextBox();
            BTN_ACTION = new Button();
            CMB_ROLE = new ComboBox();
            label8 = new Label();
            TB_BALANCE = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TB_PASSWORD
            // 
            TB_PASSWORD.Anchor = AnchorStyles.None;
            TB_PASSWORD.Location = new Point(178, 115);
            TB_PASSWORD.Name = "TB_PASSWORD";
            TB_PASSWORD.PlaceholderText = "Пароль";
            TB_PASSWORD.Size = new Size(150, 27);
            TB_PASSWORD.TabIndex = 30;
            // 
            // TB_LOGIN
            // 
            TB_LOGIN.Anchor = AnchorStyles.None;
            TB_LOGIN.Location = new Point(178, 76);
            TB_LOGIN.Name = "TB_LOGIN";
            TB_LOGIN.PlaceholderText = "Логин";
            TB_LOGIN.Size = new Size(150, 27);
            TB_LOGIN.TabIndex = 28;
            // 
            // TB_PHONE
            // 
            TB_PHONE.Anchor = AnchorStyles.None;
            TB_PHONE.Location = new Point(178, 155);
            TB_PHONE.Name = "TB_PHONE";
            TB_PHONE.PlaceholderText = "Номер телефона";
            TB_PHONE.Size = new Size(150, 27);
            TB_PHONE.TabIndex = 25;
            TB_PHONE.TextChanged += TB_PHONE_TextChanged;
            TB_PHONE.KeyDown += TB_PHONE_KeyDown;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(34, 188);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 24;
            label4.Text = "Дата рождения";
            // 
            // DATE_PICKER_BIRTHDAY
            // 
            DATE_PICKER_BIRTHDAY.Anchor = AnchorStyles.None;
            DATE_PICKER_BIRTHDAY.Location = new Point(34, 211);
            DATE_PICKER_BIRTHDAY.Name = "DATE_PICKER_BIRTHDAY";
            DATE_PICKER_BIRTHDAY.Size = new Size(294, 27);
            DATE_PICKER_BIRTHDAY.TabIndex = 23;
            // 
            // TB_PATRONYMIC
            // 
            TB_PATRONYMIC.Anchor = AnchorStyles.None;
            TB_PATRONYMIC.Location = new Point(34, 155);
            TB_PATRONYMIC.Name = "TB_PATRONYMIC";
            TB_PATRONYMIC.PlaceholderText = "Отчество";
            TB_PATRONYMIC.Size = new Size(125, 27);
            TB_PATRONYMIC.TabIndex = 22;
            // 
            // TB_NAME
            // 
            TB_NAME.Anchor = AnchorStyles.None;
            TB_NAME.Location = new Point(34, 115);
            TB_NAME.Name = "TB_NAME";
            TB_NAME.PlaceholderText = "Имя";
            TB_NAME.Size = new Size(125, 27);
            TB_NAME.TabIndex = 21;
            // 
            // TB_LASTNAME
            // 
            TB_LASTNAME.Anchor = AnchorStyles.None;
            TB_LASTNAME.Location = new Point(34, 76);
            TB_LASTNAME.Name = "TB_LASTNAME";
            TB_LASTNAME.PlaceholderText = "Фамилия";
            TB_LASTNAME.Size = new Size(125, 27);
            TB_LASTNAME.TabIndex = 20;
            // 
            // BTN_ACTION
            // 
            BTN_ACTION.Anchor = AnchorStyles.None;
            BTN_ACTION.BackColor = SystemColors.ActiveBorder;
            BTN_ACTION.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_ACTION.Location = new Point(34, 328);
            BTN_ACTION.Name = "BTN_ACTION";
            BTN_ACTION.Size = new Size(294, 51);
            BTN_ACTION.TabIndex = 31;
            BTN_ACTION.Text = "Изменить/Добавить";
            BTN_ACTION.UseVisualStyleBackColor = false;
            BTN_ACTION.Click += BTN_ACTION_Click;
            // 
            // CMB_ROLE
            // 
            CMB_ROLE.Anchor = AnchorStyles.None;
            CMB_ROLE.FormattingEnabled = true;
            CMB_ROLE.Location = new Point(178, 270);
            CMB_ROLE.Name = "CMB_ROLE";
            CMB_ROLE.Size = new Size(150, 28);
            CMB_ROLE.TabIndex = 32;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(178, 248);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 33;
            label8.Text = "Роль";
            // 
            // TB_BALANCE
            // 
            TB_BALANCE.Anchor = AnchorStyles.None;
            TB_BALANCE.Location = new Point(34, 271);
            TB_BALANCE.Name = "TB_BALANCE";
            TB_BALANCE.PlaceholderText = "Баланс";
            TB_BALANCE.Size = new Size(125, 27);
            TB_BALANCE.TabIndex = 35;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TB_PATRONYMIC);
            panel1.Controls.Add(TB_BALANCE);
            panel1.Controls.Add(TB_LASTNAME);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(TB_NAME);
            panel1.Controls.Add(CMB_ROLE);
            panel1.Controls.Add(DATE_PICKER_BIRTHDAY);
            panel1.Controls.Add(BTN_ACTION);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TB_PASSWORD);
            panel1.Controls.Add(TB_PHONE);
            panel1.Controls.Add(TB_LOGIN);
            panel1.Location = new Point(196, 19);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 406);
            panel1.TabIndex = 36;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(62, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(260, 50);
            label1.TabIndex = 36;
            label1.Text = "Пользователь";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 442);
            Controls.Add(panel1);
            MinimumSize = new Size(804, 489);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пользователь";
            Load += UserForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TB_PASSWORD;
        private TextBox TB_LOGIN;
        private TextBox TB_PHONE;
        private Label label4;
        private DateTimePicker DATE_PICKER_BIRTHDAY;
        private TextBox TB_PATRONYMIC;
        private TextBox TB_NAME;
        private TextBox TB_LASTNAME;
        private Button BTN_ACTION;
        private ComboBox CMB_ROLE;
        private Label label8;
        private TextBox TB_BALANCE;
        private Panel panel1;
        private Label label1;
    }
}