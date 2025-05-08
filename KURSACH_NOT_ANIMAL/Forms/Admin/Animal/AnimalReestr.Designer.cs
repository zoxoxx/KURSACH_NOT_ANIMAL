namespace KURSACH_NOT_ANIMAL.Forms.Reestr
{
    partial class AnimalReestr
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
            DG_ANIMALS = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            NameAnimal = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewComboBoxColumn();
            CategoryDescription = new DataGridViewTextBoxColumn();
            CategoryId = new DataGridViewTextBoxColumn();
            BTN_EDIT = new Button();
            BTN_DELETE = new Button();
            BTN_ADD = new Button();
            ((System.ComponentModel.ISupportInitialize)DG_ANIMALS).BeginInit();
            SuspendLayout();
            // 
            // DG_ANIMALS
            // 
            DG_ANIMALS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DG_ANIMALS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_ANIMALS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_ANIMALS.Columns.AddRange(new DataGridViewColumn[] { Id, NameAnimal, Description, CategoryName, CategoryDescription, CategoryId });
            DG_ANIMALS.Location = new Point(12, 48);
            DG_ANIMALS.Name = "DG_ANIMALS";
            DG_ANIMALS.RowHeadersWidth = 51;
            DG_ANIMALS.Size = new Size(776, 390);
            DG_ANIMALS.TabIndex = 0;
            DG_ANIMALS.CellBeginEdit += DG_ANIMALS_CellBeginEdit;
            DG_ANIMALS.CellValueChanged += DG_ANIMALS_CellValueChanged;
            // 
            // Id
            // 
            Id.HeaderText = "Ключ животного";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // NameAnimal
            // 
            NameAnimal.HeaderText = "Наименование животного";
            NameAnimal.MinimumWidth = 6;
            NameAnimal.Name = "NameAnimal";
            // 
            // Description
            // 
            Description.HeaderText = "Описание животного";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            // 
            // CategoryName
            // 
            CategoryName.HeaderText = "Категория";
            CategoryName.MinimumWidth = 6;
            CategoryName.Name = "CategoryName";
            // 
            // CategoryDescription
            // 
            CategoryDescription.HeaderText = "Описание категории";
            CategoryDescription.MinimumWidth = 6;
            CategoryDescription.Name = "CategoryDescription";
            CategoryDescription.Resizable = DataGridViewTriState.True;
            CategoryDescription.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // CategoryId
            // 
            CategoryId.HeaderText = "Ключ категории";
            CategoryId.MinimumWidth = 6;
            CategoryId.Name = "CategoryId";
            CategoryId.Visible = false;
            // 
            // BTN_EDIT
            // 
            BTN_EDIT.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_EDIT.Image = Properties.Resources.EditIcon;
            BTN_EDIT.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_EDIT.Location = new Point(307, 7);
            BTN_EDIT.Name = "BTN_EDIT";
            BTN_EDIT.RightToLeft = RightToLeft.No;
            BTN_EDIT.Size = new Size(198, 35);
            BTN_EDIT.TabIndex = 1;
            BTN_EDIT.Text = "Редактировать";
            BTN_EDIT.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTN_EDIT.UseVisualStyleBackColor = true;
            BTN_EDIT.Click += BTN_EDIT_Click;
            // 
            // BTN_DELETE
            // 
            BTN_DELETE.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_DELETE.Image = Properties.Resources.DeleteIcon;
            BTN_DELETE.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_DELETE.Location = new Point(561, 7);
            BTN_DELETE.Name = "BTN_DELETE";
            BTN_DELETE.RightToLeft = RightToLeft.No;
            BTN_DELETE.Size = new Size(198, 35);
            BTN_DELETE.TabIndex = 2;
            BTN_DELETE.Text = "Удалить";
            BTN_DELETE.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTN_DELETE.UseVisualStyleBackColor = true;
            BTN_DELETE.Click += BTN_DELETE_Click;
            // 
            // BTN_ADD
            // 
            BTN_ADD.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_ADD.Image = Properties.Resources.AddIcon;
            BTN_ADD.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_ADD.Location = new Point(50, 7);
            BTN_ADD.Name = "BTN_ADD";
            BTN_ADD.RightToLeft = RightToLeft.No;
            BTN_ADD.Size = new Size(198, 35);
            BTN_ADD.TabIndex = 3;
            BTN_ADD.Text = "Добавить";
            BTN_ADD.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTN_ADD.UseVisualStyleBackColor = true;
            BTN_ADD.Click += BTN_ADD_Click;
            // 
            // AnimalReestr
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_ADD);
            Controls.Add(BTN_DELETE);
            Controls.Add(BTN_EDIT);
            Controls.Add(DG_ANIMALS);
            MinimumSize = new Size(620, 393);
            Name = "AnimalReestr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Животные";
            Load += AnimalReestr_Load;
            ((System.ComponentModel.ISupportInitialize)DG_ANIMALS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DG_ANIMALS;
        private Button BTN_EDIT;
        private Button BTN_DELETE;
        private Button BTN_ADD;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NameAnimal;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewComboBoxColumn CategoryName;
        private DataGridViewTextBoxColumn CategoryDescription;
        private DataGridViewTextBoxColumn CategoryId;
    }
}