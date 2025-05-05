namespace KURSACH_NOT_ANIMAL.Forms.Admin.Shop
{
    partial class ShopReestr
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
            DG_SHOPS = new DataGridView();
            ShopId = new DataGridViewTextBoxColumn();
            ShopName = new DataGridViewTextBoxColumn();
            Adress = new DataGridViewTextBoxColumn();
            CityId = new DataGridViewTextBoxColumn();
            CityName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DG_SHOPS).BeginInit();
            SuspendLayout();
            // 
            // BTN_ADD
            // 
            BTN_ADD.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_ADD.Image = Properties.Resources.AddIcon;
            BTN_ADD.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_ADD.Location = new Point(24, 10);
            BTN_ADD.Name = "BTN_ADD";
            BTN_ADD.RightToLeft = RightToLeft.No;
            BTN_ADD.Size = new Size(198, 35);
            BTN_ADD.TabIndex = 6;
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
            BTN_DELETE.Location = new Point(239, 10);
            BTN_DELETE.Name = "BTN_DELETE";
            BTN_DELETE.RightToLeft = RightToLeft.No;
            BTN_DELETE.Size = new Size(198, 35);
            BTN_DELETE.TabIndex = 5;
            BTN_DELETE.Text = "Удалить";
            BTN_DELETE.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTN_DELETE.UseVisualStyleBackColor = true;
            BTN_DELETE.Click += BTN_DELETE_Click;
            // 
            // DG_SHOPS
            // 
            DG_SHOPS.AllowUserToAddRows = false;
            DG_SHOPS.AllowUserToDeleteRows = false;
            DG_SHOPS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DG_SHOPS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_SHOPS.Columns.AddRange(new DataGridViewColumn[] { ShopId, ShopName, Adress, CityId, CityName });
            DG_SHOPS.Location = new Point(12, 51);
            DG_SHOPS.Name = "DG_SHOPS";
            DG_SHOPS.ReadOnly = true;
            DG_SHOPS.RowHeadersWidth = 51;
            DG_SHOPS.Size = new Size(776, 390);
            DG_SHOPS.TabIndex = 4;
            DG_SHOPS.CellContentDoubleClick += DG_SHOPS_CellContentDoubleClick;
            // 
            // ShopId
            // 
            ShopId.HeaderText = "Первичный ключ";
            ShopId.MinimumWidth = 6;
            ShopId.Name = "ShopId";
            ShopId.ReadOnly = true;
            ShopId.Visible = false;
            ShopId.Width = 125;
            // 
            // ShopName
            // 
            ShopName.HeaderText = "Наименование";
            ShopName.MinimumWidth = 6;
            ShopName.Name = "ShopName";
            ShopName.ReadOnly = true;
            ShopName.Width = 200;
            // 
            // Adress
            // 
            Adress.HeaderText = "Адрес";
            Adress.MinimumWidth = 6;
            Adress.Name = "Adress";
            Adress.ReadOnly = true;
            Adress.Width = 250;
            // 
            // CityId
            // 
            CityId.HeaderText = "Внешний ключ города";
            CityId.MinimumWidth = 6;
            CityId.Name = "CityId";
            CityId.ReadOnly = true;
            CityId.Visible = false;
            CityId.Width = 125;
            // 
            // CityName
            // 
            CityName.HeaderText = "Город";
            CityName.MinimumWidth = 6;
            CityName.Name = "CityName";
            CityName.ReadOnly = true;
            CityName.Width = 150;
            // 
            // ShopReestr
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_ADD);
            Controls.Add(BTN_DELETE);
            Controls.Add(DG_SHOPS);
            Name = "ShopReestr";
            Text = "Магазины";
            Load += ShopReestr_Load;
            ((System.ComponentModel.ISupportInitialize)DG_SHOPS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BTN_ADD;
        private Button BTN_DELETE;
        private DataGridView DG_SHOPS;
        private DataGridViewTextBoxColumn ShopId;
        private DataGridViewTextBoxColumn ShopName;
        private DataGridViewTextBoxColumn Adress;
        private DataGridViewTextBoxColumn CityId;
        private DataGridViewTextBoxColumn CityName;
    }
}