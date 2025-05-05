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
            BTN_AUTORIZE = new Button();
            LINK_REGISTRATION = new LinkLabel();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TB_LOGIN
            // 
            TB_LOGIN.Anchor = AnchorStyles.None;
            TB_LOGIN.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TB_LOGIN.Location = new Point(80, 154);
            TB_LOGIN.Margin = new Padding(4);
            TB_LOGIN.Name = "TB_LOGIN";
            TB_LOGIN.PlaceholderText = "Логин";
            TB_LOGIN.Size = new Size(300, 45);
            TB_LOGIN.TabIndex = 0;
            // 
            // TB_PASSWORD
            // 
            TB_PASSWORD.Anchor = AnchorStyles.None;
            TB_PASSWORD.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TB_PASSWORD.Location = new Point(79, 217);
            TB_PASSWORD.Margin = new Padding(4);
            TB_PASSWORD.Name = "TB_PASSWORD";
            TB_PASSWORD.PasswordChar = '*';
            TB_PASSWORD.PlaceholderText = "Пароль";
            TB_PASSWORD.Size = new Size(302, 45);
            TB_PASSWORD.TabIndex = 1;
            // 
            // BTN_AUTORIZE
            // 
            BTN_AUTORIZE.Anchor = AnchorStyles.None;
            BTN_AUTORIZE.BackColor = SystemColors.ActiveBorder;
            BTN_AUTORIZE.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_AUTORIZE.ForeColor = SystemColors.ControlText;
            BTN_AUTORIZE.Location = new Point(78, 317);
            BTN_AUTORIZE.Margin = new Padding(4);
            BTN_AUTORIZE.Name = "BTN_AUTORIZE";
            BTN_AUTORIZE.Size = new Size(302, 70);
            BTN_AUTORIZE.TabIndex = 4;
            BTN_AUTORIZE.Text = "Войти";
            BTN_AUTORIZE.UseVisualStyleBackColor = false;
            BTN_AUTORIZE.Click += BTN_AUTORIZE_Click;
            // 
            // LINK_REGISTRATION
            // 
            LINK_REGISTRATION.Anchor = AnchorStyles.None;
            LINK_REGISTRATION.AutoSize = true;
            LINK_REGISTRATION.LinkColor = Color.Blue;
            LINK_REGISTRATION.Location = new Point(79, 288);
            LINK_REGISTRATION.Margin = new Padding(4, 0, 4, 0);
            LINK_REGISTRATION.Name = "LINK_REGISTRATION";
            LINK_REGISTRATION.Size = new Size(178, 25);
            LINK_REGISTRATION.TabIndex = 5;
            LINK_REGISTRATION.TabStop = true;
            LINK_REGISTRATION.Text = "Зарегистрироваться";
            LINK_REGISTRATION.LinkClicked += LINK_REGISTRATION_LinkClicked;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LINK_REGISTRATION);
            panel1.Controls.Add(BTN_AUTORIZE);
            panel1.Controls.Add(TB_LOGIN);
            panel1.Controls.Add(TB_PASSWORD);
            panel1.Location = new Point(248, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 434);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(66, 54);
            label1.Name = "label1";
            label1.Size = new Size(326, 60);
            label1.TabIndex = 6;
            label1.Text = "Вход в систему";
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 544);
            Controls.Add(panel1);
            Margin = new Padding(4);
            MinimumSize = new Size(1000, 600);
            Name = "AuthorizationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TB_LOGIN;
        private TextBox TB_PASSWORD;
        private Button BTN_AUTORIZE;
        private LinkLabel LINK_REGISTRATION;
        private Panel panel1;
        private Label label1;
    }
}
