namespace KURSACH_NOT_ANIMAL.Forms.Admin.ProductRes
{
    partial class ProductForm
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
            BTN_ACTION = new Button();
            CMB_ANIMALS = new ComboBox();
            label1 = new Label();
            TB_ANIMALS = new TextBox();
            BTN_CLEAR_ANIMALS = new Button();
            label2 = new Label();
            TB_NAME = new TextBox();
            label3 = new Label();
            TB_DESCRIPTION = new TextBox();
            label4 = new Label();
            TB_PRICE = new TextBox();
            label5 = new Label();
            TB_WEIGHT = new TextBox();
            label6 = new Label();
            TB_COMMENTARY = new TextBox();
            label7 = new Label();
            CMB_CATEGORY = new ComboBox();
            SuspendLayout();
            // 
            // BTN_ACTION
            // 
            BTN_ACTION.BackColor = SystemColors.ActiveBorder;
            BTN_ACTION.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_ACTION.Location = new Point(245, 352);
            BTN_ACTION.Name = "BTN_ACTION";
            BTN_ACTION.Size = new Size(301, 51);
            BTN_ACTION.TabIndex = 5;
            BTN_ACTION.Text = "Добавить/Изменить";
            BTN_ACTION.UseVisualStyleBackColor = false;
            BTN_ACTION.Click += BTN_ACTION_Click;
            // 
            // CMB_ANIMALS
            // 
            CMB_ANIMALS.FormattingEnabled = true;
            CMB_ANIMALS.Location = new Point(807, 65);
            CMB_ANIMALS.Name = "CMB_ANIMALS";
            CMB_ANIMALS.Size = new Size(199, 28);
            CMB_ANIMALS.TabIndex = 6;
            CMB_ANIMALS.SelectedValueChanged += CMB_ANIMALS_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(865, 28);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 7;
            label1.Text = "Животные";
            // 
            // TB_ANIMALS
            // 
            TB_ANIMALS.Location = new Point(807, 116);
            TB_ANIMALS.Multiline = true;
            TB_ANIMALS.Name = "TB_ANIMALS";
            TB_ANIMALS.Size = new Size(199, 147);
            TB_ANIMALS.TabIndex = 8;
            // 
            // BTN_CLEAR_ANIMALS
            // 
            BTN_CLEAR_ANIMALS.BackColor = SystemColors.ActiveBorder;
            BTN_CLEAR_ANIMALS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_CLEAR_ANIMALS.Location = new Point(826, 278);
            BTN_CLEAR_ANIMALS.Name = "BTN_CLEAR_ANIMALS";
            BTN_CLEAR_ANIMALS.Size = new Size(167, 51);
            BTN_CLEAR_ANIMALS.TabIndex = 9;
            BTN_CLEAR_ANIMALS.Text = "Очистить";
            BTN_CLEAR_ANIMALS.UseVisualStyleBackColor = false;
            BTN_CLEAR_ANIMALS.Click += BTN_CLEAR_ANIMALS_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 10;
            label2.Text = "Наименование";
            // 
            // TB_NAME
            // 
            TB_NAME.Location = new Point(134, 66);
            TB_NAME.Name = "TB_NAME";
            TB_NAME.Size = new Size(148, 27);
            TB_NAME.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 166);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 12;
            label3.Text = "Описание";
            // 
            // TB_DESCRIPTION
            // 
            TB_DESCRIPTION.Location = new Point(134, 163);
            TB_DESCRIPTION.Multiline = true;
            TB_DESCRIPTION.Name = "TB_DESCRIPTION";
            TB_DESCRIPTION.Size = new Size(148, 166);
            TB_DESCRIPTION.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 64);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 14;
            label4.Text = "Цена";
            // 
            // TB_PRICE
            // 
            TB_PRICE.Location = new Point(451, 64);
            TB_PRICE.Name = "TB_PRICE";
            TB_PRICE.Size = new Size(59, 27);
            TB_PRICE.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 116);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 16;
            label5.Text = "Вес";
            // 
            // TB_WEIGHT
            // 
            TB_WEIGHT.Location = new Point(450, 116);
            TB_WEIGHT.Name = "TB_WEIGHT";
            TB_WEIGHT.Size = new Size(60, 27);
            TB_WEIGHT.TabIndex = 17;
            // 
            // label6
            // 
            label6.Location = new Point(332, 166);
            label6.Name = "label6";
            label6.Size = new Size(112, 45);
            label6.TabIndex = 18;
            label6.Text = "Комментарий";
            // 
            // TB_COMMENTARY
            // 
            TB_COMMENTARY.Location = new Point(450, 166);
            TB_COMMENTARY.Multiline = true;
            TB_COMMENTARY.Name = "TB_COMMENTARY";
            TB_COMMENTARY.Size = new Size(148, 166);
            TB_COMMENTARY.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(664, 28);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 20;
            label7.Text = "Категория";
            // 
            // CMB_CATEGORY
            // 
            CMB_CATEGORY.FormattingEnabled = true;
            CMB_CATEGORY.Location = new Point(629, 66);
            CMB_CATEGORY.Name = "CMB_CATEGORY";
            CMB_CATEGORY.Size = new Size(151, 28);
            CMB_CATEGORY.TabIndex = 21;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 450);
            Controls.Add(CMB_CATEGORY);
            Controls.Add(label7);
            Controls.Add(TB_COMMENTARY);
            Controls.Add(label6);
            Controls.Add(TB_WEIGHT);
            Controls.Add(label5);
            Controls.Add(TB_PRICE);
            Controls.Add(label4);
            Controls.Add(TB_DESCRIPTION);
            Controls.Add(label3);
            Controls.Add(TB_NAME);
            Controls.Add(label2);
            Controls.Add(BTN_CLEAR_ANIMALS);
            Controls.Add(TB_ANIMALS);
            Controls.Add(label1);
            Controls.Add(CMB_ANIMALS);
            Controls.Add(BTN_ACTION);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Товар";
            Load += ProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_ACTION;
        private ComboBox CMB_ANIMALS;
        private Label label1;
        private TextBox TB_ANIMALS;
        private Button BTN_CLEAR_ANIMALS;
        private Label label2;
        private TextBox TB_NAME;
        private Label label3;
        private TextBox TB_DESCRIPTION;
        private Label label4;
        private TextBox TB_PRICE;
        private Label label5;
        private TextBox TB_WEIGHT;
        private Label label6;
        private TextBox TB_COMMENTARY;
        private Label label7;
        private ComboBox CMB_CATEGORY;
    }
}