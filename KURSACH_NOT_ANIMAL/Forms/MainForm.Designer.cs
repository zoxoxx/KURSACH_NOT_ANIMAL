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
            MENU_ITEM_SCHEDULE = new ToolStripMenuItem();
            MENU_WORK = new ToolStripMenuItem();
            MENU_ITEM_SKLAD = new ToolStripMenuItem();
            MENU_ITEM_OPERATIONS = new ToolStripMenuItem();
            MENU_PROFILE = new ToolStripMenuItem();
            DG_PRODUCTS = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Commentary = new DataGridViewTextBoxColumn();
            CategoryId = new DataGridViewTextBoxColumn();
            TB_SEARCH = new TextBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DG_PRODUCTS).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MENU_ADMIN, MENU_WORK, MENU_PROFILE });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1000, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MENU_ADMIN
            // 
            MENU_ADMIN.DropDownItems.AddRange(new ToolStripItem[] { MENU_ITEM_USERS, MENU_ITEM_PRODUCTS, MENU_ITEM_ANIMALS, MENU_ITEM_PARTNERS, MENU_ITEM_SCHEDULE });
            MENU_ADMIN.Name = "MENU_ADMIN";
            MENU_ADMIN.Size = new Size(157, 29);
            MENU_ADMIN.Text = "Администратор";
            // 
            // MENU_ITEM_USERS
            // 
            MENU_ITEM_USERS.Name = "MENU_ITEM_USERS";
            MENU_ITEM_USERS.Size = new Size(247, 34);
            MENU_ITEM_USERS.Text = "Пользователи";
            MENU_ITEM_USERS.Click += MENU_ITEM_USERS_Click;
            // 
            // MENU_ITEM_PRODUCTS
            // 
            MENU_ITEM_PRODUCTS.Name = "MENU_ITEM_PRODUCTS";
            MENU_ITEM_PRODUCTS.Size = new Size(247, 34);
            MENU_ITEM_PRODUCTS.Text = "Товары";
            MENU_ITEM_PRODUCTS.Click += MENU_ITEM_PRODUCTS_Click;
            // 
            // MENU_ITEM_ANIMALS
            // 
            MENU_ITEM_ANIMALS.Name = "MENU_ITEM_ANIMALS";
            MENU_ITEM_ANIMALS.Size = new Size(247, 34);
            MENU_ITEM_ANIMALS.Text = "Животные";
            MENU_ITEM_ANIMALS.Click += MENU_ITEM_ANIMALS_Click;
            // 
            // MENU_ITEM_PARTNERS
            // 
            MENU_ITEM_PARTNERS.Name = "MENU_ITEM_PARTNERS";
            MENU_ITEM_PARTNERS.Size = new Size(247, 34);
            MENU_ITEM_PARTNERS.Text = "Партнеры";
            MENU_ITEM_PARTNERS.Click += MENU_ITEM_PARTNERS_Click;
            // 
            // MENU_ITEM_SCHEDULE
            // 
            MENU_ITEM_SCHEDULE.Name = "MENU_ITEM_SCHEDULE";
            MENU_ITEM_SCHEDULE.Size = new Size(247, 34);
            MENU_ITEM_SCHEDULE.Text = "Рабочий график";
            MENU_ITEM_SCHEDULE.Click += MENU_ITEM_SCHEDULE_Click;
            // 
            // MENU_WORK
            // 
            MENU_WORK.DropDownItems.AddRange(new ToolStripItem[] { MENU_ITEM_SKLAD, MENU_ITEM_OPERATIONS });
            MENU_WORK.Name = "MENU_WORK";
            MENU_WORK.Size = new Size(173, 29);
            MENU_WORK.Text = "Рабочая нагрузка";
            // 
            // MENU_ITEM_SKLAD
            // 
            MENU_ITEM_SKLAD.Name = "MENU_ITEM_SKLAD";
            MENU_ITEM_SKLAD.Size = new Size(191, 34);
            MENU_ITEM_SKLAD.Text = "Закупки";
            MENU_ITEM_SKLAD.Click += MENU_ITEM_SKLAD_Click;
            // 
            // MENU_ITEM_OPERATIONS
            // 
            MENU_ITEM_OPERATIONS.Name = "MENU_ITEM_OPERATIONS";
            MENU_ITEM_OPERATIONS.Size = new Size(191, 34);
            MENU_ITEM_OPERATIONS.Text = "Продажи";
            MENU_ITEM_OPERATIONS.Click += MENU_ITEM_OPERATIONS_Click;
            // 
            // MENU_PROFILE
            // 
            MENU_PROFILE.Name = "MENU_PROFILE";
            MENU_PROFILE.Size = new Size(103, 29);
            MENU_PROFILE.Text = "Профиль";
            MENU_PROFILE.Click += MENU_PROFILE_Click;
            // 
            // DG_PRODUCTS
            // 
            DG_PRODUCTS.AllowUserToAddRows = false;
            DG_PRODUCTS.AllowUserToDeleteRows = false;
            DG_PRODUCTS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DG_PRODUCTS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_PRODUCTS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_PRODUCTS.Columns.AddRange(new DataGridViewColumn[] { Id, ProductName, Weight, Price, Category, Description, Commentary, CategoryId });
            DG_PRODUCTS.Location = new Point(24, 82);
            DG_PRODUCTS.Margin = new Padding(2);
            DG_PRODUCTS.Name = "DG_PRODUCTS";
            DG_PRODUCTS.ReadOnly = true;
            DG_PRODUCTS.RowHeadersWidth = 62;
            DG_PRODUCTS.Size = new Size(954, 468);
            DG_PRODUCTS.TabIndex = 8;
            DG_PRODUCTS.CellDoubleClick += DG_PRODUCTS_CellDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Первичный ключ товара";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Название";
            ProductName.MinimumWidth = 8;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // Weight
            // 
            Weight.HeaderText = "Вес";
            Weight.MinimumWidth = 8;
            Weight.Name = "Weight";
            Weight.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Цена";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Category
            // 
            Category.HeaderText = "Категория";
            Category.MinimumWidth = 8;
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Description
            // 
            Description.HeaderText = "Описание";
            Description.MinimumWidth = 8;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // Commentary
            // 
            Commentary.HeaderText = "Коментарий";
            Commentary.MinimumWidth = 8;
            Commentary.Name = "Commentary";
            Commentary.ReadOnly = true;
            Commentary.Visible = false;
            // 
            // CategoryId
            // 
            CategoryId.HeaderText = "Номер категории";
            CategoryId.MinimumWidth = 8;
            CategoryId.Name = "CategoryId";
            CategoryId.ReadOnly = true;
            CategoryId.Visible = false;
            // 
            // TB_SEARCH
            // 
            TB_SEARCH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_SEARCH.Location = new Point(596, 34);
            TB_SEARCH.Location = new Point(745, 42);
            TB_SEARCH.Margin = new Padding(4);
            TB_SEARCH.Name = "TB_SEARCH";
            TB_SEARCH.Size = new Size(226, 31);
            TB_SEARCH.TabIndex = 9;
            TB_SEARCH.TextChanged += TB_SEARCH_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(636, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 10;
            label1.Text = "Поиск";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(label1);
            Controls.Add(TB_SEARCH);
            Controls.Add(DG_PRODUCTS);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная страница";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DG_PRODUCTS).EndInit();
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
        private ToolStripMenuItem MENU_ITEM_SCHEDULE;
        private ToolStripMenuItem MENU_WORK;
        private ToolStripMenuItem MENU_ITEM_SKLAD;
        private ToolStripMenuItem MENU_ITEM_OPERATIONS;
        private ToolStripMenuItem MENU_PROFILE;
        private DataGridView DG_PRODUCTS;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Commentary;
        private DataGridViewTextBoxColumn CategoryId;
        private TextBox TB_SEARCH;
        private Label label1;
    }
}