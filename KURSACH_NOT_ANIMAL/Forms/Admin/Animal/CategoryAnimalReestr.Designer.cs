namespace KURSACH_NOT_ANIMAL.Forms.Animal
{
    partial class CategoryAnimalReestr
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
            DG_CATEGORIES = new DataGridView();
            CategoryId = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            CategoryDescription = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DG_CATEGORIES).BeginInit();
            SuspendLayout();
            // 
            // DG_CATEGORIES
            // 
            DG_CATEGORIES.AllowUserToAddRows = false;
            DG_CATEGORIES.AllowUserToDeleteRows = false;
            DG_CATEGORIES.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DG_CATEGORIES.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_CATEGORIES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_CATEGORIES.Columns.AddRange(new DataGridViewColumn[] { CategoryId, CategoryName, CategoryDescription });
            DG_CATEGORIES.Location = new Point(3, 2);
            DG_CATEGORIES.Name = "DG_CATEGORIES";
            DG_CATEGORIES.ReadOnly = true;
            DG_CATEGORIES.RowHeadersWidth = 51;
            DG_CATEGORIES.Size = new Size(793, 447);
            DG_CATEGORIES.TabIndex = 0;
            DG_CATEGORIES.CellDoubleClick += DG_CATEGORIES_CellDoubleClick;
            // 
            // CategoryId
            // 
            CategoryId.HeaderText = "Id";
            CategoryId.MinimumWidth = 6;
            CategoryId.Name = "CategoryId";
            CategoryId.ReadOnly = true;
            CategoryId.Visible = false;
            // 
            // CategoryName
            // 
            CategoryName.HeaderText = "Наименование";
            CategoryName.MinimumWidth = 6;
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            // 
            // CategoryDescription
            // 
            CategoryDescription.HeaderText = "Описание";
            CategoryDescription.MinimumWidth = 6;
            CategoryDescription.Name = "CategoryDescription";
            CategoryDescription.ReadOnly = true;
            // 
            // CategoryAnimalReestr
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DG_CATEGORIES);
            Name = "CategoryAnimalReestr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Реестр категорий животных";
            Load += CategoryAnimalReestr_Load;
            ((System.ComponentModel.ISupportInitialize)DG_CATEGORIES).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DG_CATEGORIES;
        private DataGridViewTextBoxColumn CategoryId;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn CategoryDescription;
    }
}