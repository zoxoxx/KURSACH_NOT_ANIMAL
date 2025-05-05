namespace KURSACH_NOT_ANIMAL.Forms
{
    partial class ProfileForm
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
            TB_PHONE = new TextBox();
            label4 = new Label();
            DATE_PICKER_BIRTHDAY = new DateTimePicker();
            TB_PATRONYMIC = new TextBox();
            TB_NAME = new TextBox();
            TB_LASTNAME = new TextBox();
            BTN_EDIT = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TB_PHONE
            // 
            TB_PHONE.Anchor = AnchorStyles.None;
            TB_PHONE.Font = new Font("Segoe UI", 10F);
            TB_PHONE.Location = new Point(44, 332);
            TB_PHONE.Margin = new Padding(4);
            TB_PHONE.Name = "TB_PHONE";
            TB_PHONE.PlaceholderText = "Номер телефона";
            TB_PHONE.Size = new Size(266, 34);
            TB_PHONE.TabIndex = 25;
            TB_PHONE.TextChanged += TB_PHONE_TextChanged;
            TB_PHONE.KeyDown += TB_PHONE_KeyDown;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(45, 245);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 24;
            label4.Text = "Дата рождения";
            // 
            // DATE_PICKER_BIRTHDAY
            // 
            DATE_PICKER_BIRTHDAY.Anchor = AnchorStyles.None;
            DATE_PICKER_BIRTHDAY.Font = new Font("Segoe UI", 10F);
            DATE_PICKER_BIRTHDAY.Location = new Point(44, 274);
            DATE_PICKER_BIRTHDAY.Margin = new Padding(4);
            DATE_PICKER_BIRTHDAY.Name = "DATE_PICKER_BIRTHDAY";
            DATE_PICKER_BIRTHDAY.Size = new Size(266, 34);
            DATE_PICKER_BIRTHDAY.TabIndex = 23;
            // 
            // TB_PATRONYMIC
            // 
            TB_PATRONYMIC.Anchor = AnchorStyles.None;
            TB_PATRONYMIC.Font = new Font("Segoe UI", 10F);
            TB_PATRONYMIC.Location = new Point(44, 205);
            TB_PATRONYMIC.Margin = new Padding(4);
            TB_PATRONYMIC.Name = "TB_PATRONYMIC";
            TB_PATRONYMIC.PlaceholderText = "Отчество";
            TB_PATRONYMIC.Size = new Size(267, 34);
            TB_PATRONYMIC.TabIndex = 22;
            // 
            // TB_NAME
            // 
            TB_NAME.Anchor = AnchorStyles.None;
            TB_NAME.Font = new Font("Segoe UI", 10F);
            TB_NAME.Location = new Point(44, 151);
            TB_NAME.Margin = new Padding(4);
            TB_NAME.Name = "TB_NAME";
            TB_NAME.PlaceholderText = "Имя";
            TB_NAME.Size = new Size(267, 34);
            TB_NAME.TabIndex = 21;
            // 
            // TB_LASTNAME
            // 
            TB_LASTNAME.Anchor = AnchorStyles.None;
            TB_LASTNAME.Font = new Font("Segoe UI", 10F);
            TB_LASTNAME.Location = new Point(44, 96);
            TB_LASTNAME.Margin = new Padding(4);
            TB_LASTNAME.Name = "TB_LASTNAME";
            TB_LASTNAME.PlaceholderText = "Фамилия";
            TB_LASTNAME.Size = new Size(267, 34);
            TB_LASTNAME.TabIndex = 20;
            // 
            // BTN_EDIT
            // 
            BTN_EDIT.Anchor = AnchorStyles.None;
            BTN_EDIT.BackColor = SystemColors.ActiveBorder;
            BTN_EDIT.Location = new Point(45, 404);
            BTN_EDIT.Margin = new Padding(4);
            BTN_EDIT.Name = "BTN_EDIT";
            BTN_EDIT.Size = new Size(267, 60);
            BTN_EDIT.TabIndex = 27;
            BTN_EDIT.Text = "Сохранить";
            BTN_EDIT.UseVisualStyleBackColor = false;
            BTN_EDIT.Click += BTN_EDIT_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TB_PATRONYMIC);
            panel1.Controls.Add(BTN_EDIT);
            panel1.Controls.Add(TB_LASTNAME);
            panel1.Controls.Add(TB_PHONE);
            panel1.Controls.Add(TB_NAME);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(DATE_PICKER_BIRTHDAY);
            panel1.Location = new Point(299, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 493);
            panel1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(69, 14);
            label1.Name = "label1";
            label1.Size = new Size(209, 60);
            label1.TabIndex = 28;
            label1.Text = "Профиль";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Профиль";
            Load += ProfileForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox TB_PHONE;
        private Label label4;
        private DateTimePicker DATE_PICKER_BIRTHDAY;
        private TextBox TB_PATRONYMIC;
        private TextBox TB_NAME;
        private TextBox TB_LASTNAME;
        private Button BTN_EDIT;
        private Panel panel1;
        private Label label1;
    }
}