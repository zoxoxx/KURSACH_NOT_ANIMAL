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
            BTN_EDIT = new Button();
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
            BTN_ADD.Location = new Point(43, 13);
            BTN_ADD.Margin = new Padding(4);
            BTN_ADD.Name = "BTN_ADD";
            BTN_ADD.RightToLeft = RightToLeft.No;
            BTN_ADD.Size = new Size(248, 44);
            BTN_ADD.TabIndex = 4;
            BTN_ADD.Text = "Добавить";
            BTN_ADD.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTN_ADD.UseVisualStyleBackColor = true;
            // 
            // BTN_EDIT
            // 
            BTN_EDIT.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_EDIT.Image = Properties.Resources.EditIcon;
            BTN_EDIT.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_EDIT.Location = new Point(352, 13);
            BTN_EDIT.Margin = new Padding(4);
            BTN_EDIT.Name = "BTN_EDIT";
            BTN_EDIT.RightToLeft = RightToLeft.No;
            BTN_EDIT.Size = new Size(248, 44);
            BTN_EDIT.TabIndex = 5;
            BTN_EDIT.Text = "Редактировать";
            BTN_EDIT.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTN_EDIT.UseVisualStyleBackColor = true;
            // 
            // BTN_DELETE
            // 
            BTN_DELETE.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_DELETE.Image = Properties.Resources.DeleteIcon;
            BTN_DELETE.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_DELETE.Location = new Point(653, 13);
            BTN_DELETE.Margin = new Padding(4);
            BTN_DELETE.Name = "BTN_DELETE";
            BTN_DELETE.RightToLeft = RightToLeft.No;
            BTN_DELETE.Size = new Size(248, 44);
            BTN_DELETE.TabIndex = 6;
            BTN_DELETE.Text = "Удалить";
            BTN_DELETE.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTN_DELETE.UseVisualStyleBackColor = true;
            // 
            // DG_PRODUCTS
            // 
            DG_PRODUCTS.AllowUserToAddRows = false;
            DG_PRODUCTS.AllowUserToDeleteRows = false;
            DG_PRODUCTS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DG_PRODUCTS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_PRODUCTS.Columns.AddRange(new DataGridViewColumn[] { Id, ProductName, Weight, Price, Category, Description, Commentary, CategoryId });
            DG_PRODUCTS.Location = new Point(12, 64);
            DG_PRODUCTS.Name = "DG_PRODUCTS";
            DG_PRODUCTS.ReadOnly = true;
            DG_PRODUCTS.RowHeadersWidth = 62;
            DG_PRODUCTS.Size = new Size(954, 468);
            DG_PRODUCTS.TabIndex = 7;
            // 
            // Id
            // 
            Id.HeaderText = "Номер товара";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 150;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Название";
            ProductName.MinimumWidth = 8;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 150;
            // 
            // Weight
            // 
            Weight.HeaderText = "Вес";
            Weight.MinimumWidth = 8;
            Weight.Name = "Weight";
            Weight.ReadOnly = true;
            Weight.Width = 150;
            // 
            // Price
            // 
            Price.HeaderText = "Цена";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 150;
            // 
            // Category
            // 
            Category.HeaderText = "Категория";
            Category.MinimumWidth = 8;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 150;
            // 
            // Description
            // 
            Description.HeaderText = "Описание";
            Description.MinimumWidth = 8;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 150;
            // 
            // Commentary
            // 
            Commentary.HeaderText = "Коментарий";
            Commentary.MinimumWidth = 8;
            Commentary.Name = "Commentary";
            Commentary.ReadOnly = true;
            Commentary.Visible = false;
            Commentary.Width = 150;
            // 
            // CategoryId
            // 
            CategoryId.HeaderText = "Номер категории";
            CategoryId.MinimumWidth = 8;
            CategoryId.Name = "CategoryId";
            CategoryId.ReadOnly = true;
            CategoryId.Visible = false;
            CategoryId.Width = 150;
            // 
            // ProductReestr
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 544);
            Controls.Add(DG_PRODUCTS);
            Controls.Add(BTN_DELETE);
            Controls.Add(BTN_EDIT);
            Controls.Add(BTN_ADD);
            MinimumSize = new Size(1000, 600);
            Name = "ProductReestr";
            Text = "ProductReestr";
            ((System.ComponentModel.ISupportInitialize)DG_PRODUCTS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BTN_ADD;
        private Button BTN_EDIT;
        private Button BTN_DELETE;
        private DataGridView DG_PRODUCTS;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Commentary;
        private DataGridViewTextBoxColumn CategoryId;
    }
}