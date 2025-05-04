namespace KURSACH_NOT_ANIMAL
{
    partial class AuthorizationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TB_LOGIN = new TextBox();
            TB_PASSWORD = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BTN_AUTORIZE = new Button();
            LINK_REGISTRATION = new LinkLabel();
            SuspendLayout();
            // 
            // TB_LOGIN
            // 
            TB_LOGIN.Anchor = AnchorStyles.None;
            TB_LOGIN.Location = new Point(284, 174);
            TB_LOGIN.Name = "TB_LOGIN";
            TB_LOGIN.Size = new Size(241, 27);
            TB_LOGIN.TabIndex = 0;
            // 
            // TB_PASSWORD
            // 
            TB_PASSWORD.Anchor = AnchorStyles.None;
            TB_PASSWORD.Location = new Point(283, 225);
            TB_PASSWORD.Name = "TB_PASSWORD";
            TB_PASSWORD.Size = new Size(242, 27);
            TB_PASSWORD.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(216, 177);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(212, 228);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // BTN_AUTORIZE
            // 
            BTN_AUTORIZE.Anchor = AnchorStyles.None;
            BTN_AUTORIZE.Location = new Point(284, 288);
            BTN_AUTORIZE.Name = "BTN_AUTORIZE";
            BTN_AUTORIZE.Size = new Size(94, 29);
            BTN_AUTORIZE.TabIndex = 4;
            BTN_AUTORIZE.Text = "Войти";
            BTN_AUTORIZE.UseVisualStyleBackColor = true;
            BTN_AUTORIZE.Click += BTN_AUTORIZE_Click;
            // 
            // LINK_REGISTRATION
            // 
            LINK_REGISTRATION.Anchor = AnchorStyles.None;
            LINK_REGISTRATION.AutoSize = true;
            LINK_REGISTRATION.Location = new Point(429, 292);
            LINK_REGISTRATION.Name = "LINK_REGISTRATION";
            LINK_REGISTRATION.Size = new Size(96, 20);
            LINK_REGISTRATION.TabIndex = 5;
            LINK_REGISTRATION.TabStop = true;
            LINK_REGISTRATION.Text = "Регистрация";
            LINK_REGISTRATION.LinkClicked += LINK_REGISTRATION_LinkClicked;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LINK_REGISTRATION);
            Controls.Add(BTN_AUTORIZE);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TB_PASSWORD);
            Controls.Add(TB_LOGIN);
            Name = "AuthorizationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_LOGIN;
        private TextBox TB_PASSWORD;
        private Label label1;
        private Label label2;
        private Button BTN_AUTORIZE;
        private LinkLabel LINK_REGISTRATION;
    }
}
