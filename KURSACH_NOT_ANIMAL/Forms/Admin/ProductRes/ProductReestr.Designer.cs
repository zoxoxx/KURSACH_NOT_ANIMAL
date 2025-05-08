namespace KURSACH_NOT_ANIMAL.Forms.Admin.ProductRes
{
    partial class ProductReestr
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
            BTN_ADD = new Button();
            BTN_DELETE = new Button();
            DG_PRODUCTS = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Commentary = new DataGridViewTextBoxColumn();
            CategoryId = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DG_PRODUCTS).BeginInit();
            SuspendLayout();
            // 
            // BTN_ADD
            // 
            BTN_ADD.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_ADD.Image = Properties.Resources.AddIcon;
            BTN_ADD.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_ADD.Location = new Point(34, 10);
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
            BTN_DELETE.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_DELETE.Image = Properties.Resources.DeleteIcon;
            BTN_DELETE.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_DELETE.Location = new Point(251, 10);
            BTN_DELETE.Name = "BTN_DELETE";
            BTN_DELETE.RightToLeft = RightToLeft.No;
            BTN_DELETE.Size = new Size(198, 35);
            BTN_DELETE.TabIndex = 6;
            BTN_DELETE.Text = "Удалить";
            BTN_DELETE.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTN_DELETE.UseVisualStyleBackColor = true;
            BTN_DELETE.Click += BTN_DELETE_Click;
            // 
            // DG_PRODUCTS
            // 
            DG_PRODUCTS.AllowUserToAddRows = false;
            DG_PRODUCTS.AllowUserToDeleteRows = false;
            DG_PRODUCTS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DG_PRODUCTS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_PRODUCTS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_PRODUCTS.Columns.AddRange(new DataGridViewColumn[] { Id, ProductName, Weight, Price, Category, Description, Commentary, CategoryId });
            DG_PRODUCTS.Location = new Point(10, 51);
            DG_PRODUCTS.Margin = new Padding(2);
            DG_PRODUCTS.Name = "DG_PRODUCTS";
            DG_PRODUCTS.ReadOnly = true;
            DG_PRODUCTS.RowHeadersWidth = 62;
            DG_PRODUCTS.Size = new Size(763, 374);
            DG_PRODUCTS.TabIndex = 7;
            DG_PRODUCTS.CellContentDoubleClick += DG_PRODUCTS_CellContentDoubleClick;
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
            // ProductReestr
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 442);
            Controls.Add(DG_PRODUCTS);
            Controls.Add(BTN_DELETE);
            Controls.Add(BTN_ADD);
            Margin = new Padding(2);
            MinimumSize = new Size(804, 489);
            Name = "ProductReestr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Товары";
            Load += ProductReestr_Load;
            ((System.ComponentModel.ISupportInitialize)DG_PRODUCTS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BTN_ADD;
        private Button BTN_DELETE;
        private DataGridView DG_PRODUCTS;
        private DataGridViewTextBoxColumn Id;
        private new DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Commentary;
        private DataGridViewTextBoxColumn CategoryId;
    }
}