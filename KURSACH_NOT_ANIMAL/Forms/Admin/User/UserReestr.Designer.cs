namespace KURSACH_NOT_ANIMAL.Forms.Admin
{
    partial class UserReestr
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
            DG_USERS = new DataGridView();
            UserId = new DataGridViewTextBoxColumn();
            Phyo = new DataGridViewTextBoxColumn();
            RoleId = new DataGridViewTextBoxColumn();
            RoleName = new DataGridViewTextBoxColumn();
            Birthday = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            Login = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            BTN_ADD = new Button();
            BTN_DELETE = new Button();
            ((System.ComponentModel.ISupportInitialize)DG_USERS).BeginInit();
            SuspendLayout();
            // 
            // DG_USERS
            // 
            DG_USERS.AllowUserToAddRows = false;
            DG_USERS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DG_USERS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_USERS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_USERS.Columns.AddRange(new DataGridViewColumn[] { UserId, Phyo, RoleId, RoleName, Birthday, Phone, Balance, Login, Password });
            DG_USERS.Location = new Point(6, 44);
            DG_USERS.Name = "DG_USERS";
            DG_USERS.ReadOnly = true;
            DG_USERS.RowHeadersWidth = 51;
            DG_USERS.Size = new Size(790, 404);
            DG_USERS.TabIndex = 1;
            DG_USERS.CellDoubleClick += DG_USERS_CellDoubleClick;
            // 
            // UserId
            // 
            UserId.HeaderText = "Первичный ключ пользователя";
            UserId.MinimumWidth = 6;
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            UserId.Visible = false;
            // 
            // Phyo
            // 
            Phyo.HeaderText = "ФИО";
            Phyo.MinimumWidth = 6;
            Phyo.Name = "Phyo";
            Phyo.ReadOnly = true;
            // 
            // RoleId
            // 
            RoleId.HeaderText = "Внешний ключ роли";
            RoleId.MinimumWidth = 6;
            RoleId.Name = "RoleId";
            RoleId.ReadOnly = true;
            RoleId.Visible = false;
            // 
            // RoleName
            // 
            RoleName.HeaderText = "Роль";
            RoleName.MinimumWidth = 6;
            RoleName.Name = "RoleName";
            RoleName.ReadOnly = true;
            // 
            // Birthday
            // 
            Birthday.HeaderText = "Дата рождения";
            Birthday.MinimumWidth = 6;
            Birthday.Name = "Birthday";
            Birthday.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.HeaderText = "Телефон";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // Balance
            // 
            Balance.HeaderText = "Баланс";
            Balance.MinimumWidth = 6;
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            // 
            // Login
            // 
            Login.HeaderText = "Логин";
            Login.MinimumWidth = 6;
            Login.Name = "Login";
            Login.ReadOnly = true;
            // 
            // Password
            // 
            Password.HeaderText = "Пароль";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // BTN_ADD
            // 
            BTN_ADD.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_ADD.Image = Properties.Resources.AddIcon;
            BTN_ADD.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_ADD.Location = new Point(6, 3);
            BTN_ADD.Name = "BTN_ADD";
            BTN_ADD.RightToLeft = RightToLeft.No;
            BTN_ADD.Size = new Size(198, 35);
            BTN_ADD.TabIndex = 4;
            BTN_ADD.Text = "Добавить";
            BTN_ADD.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTN_ADD.UseVisualStyleBackColor = true;
            BTN_ADD.Click += BTN_ADD_Click;
            // 
            // BTN_DELETE
            // 
            BTN_DELETE.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_DELETE.Image = Properties.Resources.DeleteIcon;
            BTN_DELETE.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_DELETE.Location = new Point(226, 3);
            BTN_DELETE.Name = "BTN_DELETE";
            BTN_DELETE.RightToLeft = RightToLeft.No;
            BTN_DELETE.Size = new Size(198, 35);
            BTN_DELETE.TabIndex = 5;
            BTN_DELETE.Text = "Удалить";
            BTN_DELETE.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTN_DELETE.UseVisualStyleBackColor = true;
            BTN_DELETE.Click += BTN_DELETE_Click;
            // 
            // UserReestr
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_DELETE);
            Controls.Add(BTN_ADD);
            Controls.Add(DG_USERS);
            Name = "UserReestr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пользователи";
            Load += UserReestr_Load;
            ((System.ComponentModel.ISupportInitialize)DG_USERS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DG_USERS;
        private Button BTN_ADD;
        private Button BTN_DELETE;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn Phyo;
        private DataGridViewTextBoxColumn RoleId;
        private DataGridViewTextBoxColumn RoleName;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn Password;
    }
}