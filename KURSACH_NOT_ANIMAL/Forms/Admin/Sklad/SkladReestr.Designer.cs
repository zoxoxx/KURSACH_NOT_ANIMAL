﻿namespace KURSACH_NOT_ANIMAL.Forms.Admin.Sklad
{
    partial class SkladReestr
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
            DG_SKLAD = new DataGridView();
            SkladId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductCount = new DataGridViewTextBoxColumn();
            ShopName = new DataGridViewTextBoxColumn();
            PartnerName = new DataGridViewTextBoxColumn();
            PurchasePrice = new DataGridViewTextBoxColumn();
            DatePrihod = new DataGridViewTextBoxColumn();
            BTN_DELETE = new Button();
            ((System.ComponentModel.ISupportInitialize)DG_SKLAD).BeginInit();
            SuspendLayout();
            // 
            // BTN_ADD
            // 
            BTN_ADD.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_ADD.Image = Properties.Resources.AddIcon;
            BTN_ADD.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_ADD.Location = new Point(32, 10);
            BTN_ADD.Name = "BTN_ADD";
            BTN_ADD.RightToLeft = RightToLeft.No;
            BTN_ADD.Size = new Size(198, 35);
            BTN_ADD.TabIndex = 5;
            BTN_ADD.Text = "Добавить";
            BTN_ADD.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTN_ADD.UseVisualStyleBackColor = true;
            BTN_ADD.Click += BTN_ADD_Click;
            // 
            // DG_SKLAD
            // 
            DG_SKLAD.AllowUserToAddRows = false;
            DG_SKLAD.AllowUserToDeleteRows = false;
            DG_SKLAD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DG_SKLAD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_SKLAD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_SKLAD.Columns.AddRange(new DataGridViewColumn[] { SkladId, ProductName, ProductCount, ShopName, PartnerName, PurchasePrice, DatePrihod });
            DG_SKLAD.Location = new Point(12, 51);
            DG_SKLAD.Name = "DG_SKLAD";
            DG_SKLAD.ReadOnly = true;
            DG_SKLAD.RowHeadersWidth = 51;
            DG_SKLAD.Size = new Size(776, 390);
            DG_SKLAD.TabIndex = 4;
            DG_SKLAD.CellContentDoubleClick += DG_SKLAD_CellContentDoubleClick;
            // 
            // SkladId
            // 
            SkladId.HeaderText = "Первичный ключ закупки";
            SkladId.MinimumWidth = 6;
            SkladId.Name = "SkladId";
            SkladId.ReadOnly = true;
            SkladId.Visible = false;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Товар";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // ProductCount
            // 
            ProductCount.HeaderText = "Количество";
            ProductCount.MinimumWidth = 6;
            ProductCount.Name = "ProductCount";
            ProductCount.ReadOnly = true;
            // 
            // ShopName
            // 
            ShopName.HeaderText = "Магазин";
            ShopName.MinimumWidth = 6;
            ShopName.Name = "ShopName";
            ShopName.ReadOnly = true;
            // 
            // PartnerName
            // 
            PartnerName.HeaderText = "Партнер";
            PartnerName.MinimumWidth = 6;
            PartnerName.Name = "PartnerName";
            PartnerName.ReadOnly = true;
            // 
            // PurchasePrice
            // 
            PurchasePrice.HeaderText = "Цена закупки";
            PurchasePrice.MinimumWidth = 6;
            PurchasePrice.Name = "PurchasePrice";
            PurchasePrice.ReadOnly = true;
            // 
            // DatePrihod
            // 
            DatePrihod.HeaderText = "Дата";
            DatePrihod.MinimumWidth = 6;
            DatePrihod.Name = "DatePrihod";
            DatePrihod.ReadOnly = true;
            // 
            // BTN_DELETE
            // 
            BTN_DELETE.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_DELETE.Image = Properties.Resources.DeleteIcon;
            BTN_DELETE.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_DELETE.Location = new Point(260, 10);
            BTN_DELETE.Name = "BTN_DELETE";
            BTN_DELETE.RightToLeft = RightToLeft.No;
            BTN_DELETE.Size = new Size(198, 35);
            BTN_DELETE.TabIndex = 6;
            BTN_DELETE.Text = "Удалить";
            BTN_DELETE.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTN_DELETE.UseVisualStyleBackColor = true;
            BTN_DELETE.Click += BTN_DELETE_Click;
            // 
            // SkladReestr
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_DELETE);
            Controls.Add(BTN_ADD);
            Controls.Add(DG_SKLAD);
            Name = "SkladReestr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Закупки";
            Load += SkladReestr_Load;
            ((System.ComponentModel.ISupportInitialize)DG_SKLAD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BTN_ADD;
        private DataGridView DG_SKLAD;
        private Button BTN_DELETE;
        private DataGridViewTextBoxColumn SkladId;
        private new DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductCount;
        private DataGridViewTextBoxColumn ShopName;
        private DataGridViewTextBoxColumn PartnerName;
        private DataGridViewTextBoxColumn PurchasePrice;
        private DataGridViewTextBoxColumn DatePrihod;
    }
}