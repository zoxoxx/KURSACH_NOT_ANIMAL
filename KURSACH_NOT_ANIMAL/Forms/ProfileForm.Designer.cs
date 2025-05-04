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
            BTN_EDIT = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(396, 218);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 26;
            label5.Text = "Номер телефона";
            // 
            // TB_PHONE
            // 
            TB_PHONE.Anchor = AnchorStyles.None;
            TB_PHONE.Location = new Point(540, 215);
            TB_PHONE.Name = "TB_PHONE";
            TB_PHONE.Size = new Size(125, 27);
            TB_PHONE.TabIndex = 25;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(468, 142);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 24;
            label4.Text = "Дата рождения";
            // 
            // DATE_PICKER_BIRTHDAY
            // 
            DATE_PICKER_BIRTHDAY.Anchor = AnchorStyles.None;
            DATE_PICKER_BIRTHDAY.Location = new Point(396, 175);
            DATE_PICKER_BIRTHDAY.Name = "DATE_PICKER_BIRTHDAY";
            DATE_PICKER_BIRTHDAY.Size = new Size(250, 27);
            DATE_PICKER_BIRTHDAY.TabIndex = 23;
            // 
            // TB_PATRONYMIC
            // 
            TB_PATRONYMIC.Anchor = AnchorStyles.None;
            TB_PATRONYMIC.Location = new Point(232, 215);
            TB_PATRONYMIC.Name = "TB_PATRONYMIC";
            TB_PATRONYMIC.Size = new Size(125, 27);
            TB_PATRONYMIC.TabIndex = 22;
            // 
            // TB_NAME
            // 
            TB_NAME.Anchor = AnchorStyles.None;
            TB_NAME.Location = new Point(232, 179);
            TB_NAME.Name = "TB_NAME";
            TB_NAME.Size = new Size(125, 27);
            TB_NAME.TabIndex = 21;
            // 
            // TB_LASTNAME
            // 
            TB_LASTNAME.Anchor = AnchorStyles.None;
            TB_LASTNAME.Location = new Point(232, 146);
            TB_LASTNAME.Name = "TB_LASTNAME";
            TB_LASTNAME.Size = new Size(125, 27);
            TB_LASTNAME.TabIndex = 20;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(138, 215);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 19;
            label3.Text = "Отчество";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(138, 178);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 18;
            label2.Text = "Имя";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(137, 146);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 17;
            label1.Text = "Фамилия";
            // 
            // BTN_EDIT
            // 
            BTN_EDIT.Anchor = AnchorStyles.None;
            BTN_EDIT.Location = new Point(320, 297);
            BTN_EDIT.Name = "BTN_EDIT";
            BTN_EDIT.Size = new Size(127, 48);
            BTN_EDIT.TabIndex = 27;
            BTN_EDIT.Text = "Изменить";
            BTN_EDIT.UseVisualStyleBackColor = true;
            BTN_EDIT.Click += BTN_EDIT_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_EDIT);
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
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Профиль";
            Load += ProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button BTN_EDIT;
    }
}