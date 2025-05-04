namespace KURSACH_NOT_ANIMAL.Forms
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            MENU_ADMIN = new ToolStripMenuItem();
            MENU_ITEM_USERS = new ToolStripMenuItem();
            MENU_ITEM_PRODUCTS = new ToolStripMenuItem();
            MENU_ITEM_ANIMALS = new ToolStripMenuItem();
            MENU_ITEM_PARTNERS = new ToolStripMenuItem();
            MENU_ITEM_SHOPS = new ToolStripMenuItem();
            MENU_ITEM_SCHEDULE = new ToolStripMenuItem();
            MENU_WORK = new ToolStripMenuItem();
            MENU_ITEM_SKLAD = new ToolStripMenuItem();
            MENU_ITEM_OPERATIONS = new ToolStripMenuItem();
            MENU_PROFILE = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MENU_ADMIN, MENU_WORK, MENU_PROFILE });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MENU_ADMIN
            // 
            MENU_ADMIN.DropDownItems.AddRange(new ToolStripItem[] { MENU_ITEM_USERS, MENU_ITEM_PRODUCTS, MENU_ITEM_ANIMALS, MENU_ITEM_PARTNERS, MENU_ITEM_SHOPS, MENU_ITEM_SCHEDULE });
            MENU_ADMIN.Name = "MENU_ADMIN";
            MENU_ADMIN.Size = new Size(133, 24);
            MENU_ADMIN.Text = "Администратор";
            // 
            // MENU_ITEM_USERS
            // 
            MENU_ITEM_USERS.Name = "MENU_ITEM_USERS";
            MENU_ITEM_USERS.Size = new Size(224, 26);
            MENU_ITEM_USERS.Text = "Пользователи";
            // 
            // MENU_ITEM_PRODUCTS
            // 
            MENU_ITEM_PRODUCTS.Name = "MENU_ITEM_PRODUCTS";
            MENU_ITEM_PRODUCTS.Size = new Size(224, 26);
            MENU_ITEM_PRODUCTS.Text = "Товары";
            // 
            // MENU_ITEM_ANIMALS
            // 
            MENU_ITEM_ANIMALS.Name = "MENU_ITEM_ANIMALS";
            MENU_ITEM_ANIMALS.Size = new Size(224, 26);
            MENU_ITEM_ANIMALS.Text = "Животные";
            MENU_ITEM_ANIMALS.Click += MENU_ITEM_ANIMALS_Click;
            // 
            // MENU_ITEM_PARTNERS
            // 
            MENU_ITEM_PARTNERS.Name = "MENU_ITEM_PARTNERS";
            MENU_ITEM_PARTNERS.Size = new Size(224, 26);
            MENU_ITEM_PARTNERS.Text = "Партнеры";
            // 
            // MENU_ITEM_SHOPS
            // 
            MENU_ITEM_SHOPS.Name = "MENU_ITEM_SHOPS";
            MENU_ITEM_SHOPS.Size = new Size(224, 26);
            MENU_ITEM_SHOPS.Text = "Магазины";
            // 
            // MENU_ITEM_SCHEDULE
            // 
            MENU_ITEM_SCHEDULE.Name = "MENU_ITEM_SCHEDULE";
            MENU_ITEM_SCHEDULE.Size = new Size(224, 26);
            MENU_ITEM_SCHEDULE.Text = "Рабочий график";
            // 
            // MENU_WORK
            // 
            MENU_WORK.DropDownItems.AddRange(new ToolStripItem[] { MENU_ITEM_SKLAD, MENU_ITEM_OPERATIONS });
            MENU_WORK.Name = "MENU_WORK";
            MENU_WORK.Size = new Size(146, 24);
            MENU_WORK.Text = "Рабочая нагрузка";
            // 
            // MENU_ITEM_SKLAD
            // 
            MENU_ITEM_SKLAD.Name = "MENU_ITEM_SKLAD";
            MENU_ITEM_SKLAD.Size = new Size(157, 26);
            MENU_ITEM_SKLAD.Text = "Закупки";
            // 
            // MENU_ITEM_OPERATIONS
            // 
            MENU_ITEM_OPERATIONS.Name = "MENU_ITEM_OPERATIONS";
            MENU_ITEM_OPERATIONS.Size = new Size(157, 26);
            MENU_ITEM_OPERATIONS.Text = "Продажи";
            // 
            // MENU_PROFILE
            // 
            MENU_PROFILE.Name = "MENU_PROFILE";
            MENU_PROFILE.Size = new Size(87, 24);
            MENU_PROFILE.Text = "Профиль";
            MENU_PROFILE.Click += MENU_PROFILE_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная страница";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MENU_ADMIN;
        private ToolStripMenuItem MENU_ITEM_USERS;
        private ToolStripMenuItem MENU_ITEM_PRODUCTS;
        private ToolStripMenuItem MENU_ITEM_ANIMALS;
        private ToolStripMenuItem MENU_ITEM_PARTNERS;
        private ToolStripMenuItem MENU_ITEM_SHOPS;
        private ToolStripMenuItem MENU_ITEM_SCHEDULE;
        private ToolStripMenuItem MENU_WORK;
        private ToolStripMenuItem MENU_ITEM_SKLAD;
        private ToolStripMenuItem MENU_ITEM_OPERATIONS;
        private ToolStripMenuItem MENU_PROFILE;
    }
}