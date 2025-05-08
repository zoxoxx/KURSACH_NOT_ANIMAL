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
            TB_NAME = new TextBox();
            TB_DESCRIPTION = new TextBox();
            TB_PRICE = new TextBox();
            TB_WEIGHT = new TextBox();
            label7 = new Label();
            CMB_CATEGORY = new ComboBox();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BTN_ACTION
            // 
            BTN_ACTION.BackColor = SystemColors.ActiveBorder;
            BTN_ACTION.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_ACTION.Location = new Point(31, 452);
            BTN_ACTION.Margin = new Padding(4);
            BTN_ACTION.Name = "BTN_ACTION";
            BTN_ACTION.Size = new Size(440, 64);
            BTN_ACTION.TabIndex = 5;
            BTN_ACTION.Text = "Добавить/Изменить";
            BTN_ACTION.UseVisualStyleBackColor = false;
            BTN_ACTION.Click += BTN_ACTION_Click;
            // 
            // CMB_ANIMALS
            // 
            CMB_ANIMALS.FormattingEnabled = true;
            CMB_ANIMALS.Location = new Point(254, 215);
            CMB_ANIMALS.Margin = new Padding(4);
            CMB_ANIMALS.Name = "CMB_ANIMALS";
            CMB_ANIMALS.Size = new Size(217, 33);
            CMB_ANIMALS.TabIndex = 6;
            CMB_ANIMALS.SelectedValueChanged += CMB_ANIMALS_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 186);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 7;
            label1.Text = "Животные";
            // 
            // TB_ANIMALS
            // 
            TB_ANIMALS.Location = new Point(254, 246);
            TB_ANIMALS.Margin = new Padding(4);
            TB_ANIMALS.Multiline = true;
            TB_ANIMALS.Name = "TB_ANIMALS";
            TB_ANIMALS.Size = new Size(217, 183);
            TB_ANIMALS.TabIndex = 8;
            // 
            // BTN_CLEAR_ANIMALS
            // 
            BTN_CLEAR_ANIMALS.BackColor = SystemColors.ActiveBorder;
            BTN_CLEAR_ANIMALS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_CLEAR_ANIMALS.Location = new Point(423, 391);
            BTN_CLEAR_ANIMALS.Margin = new Padding(4);
            BTN_CLEAR_ANIMALS.Name = "BTN_CLEAR_ANIMALS";
            BTN_CLEAR_ANIMALS.Size = new Size(48, 39);
            BTN_CLEAR_ANIMALS.TabIndex = 9;
            BTN_CLEAR_ANIMALS.Text = "X";
            BTN_CLEAR_ANIMALS.UseVisualStyleBackColor = false;
            BTN_CLEAR_ANIMALS.Click += BTN_CLEAR_ANIMALS_Click;
            // 
            // TB_NAME
            // 
            TB_NAME.Location = new Point(27, 88);
            TB_NAME.Margin = new Padding(4);
            TB_NAME.Name = "TB_NAME";
            TB_NAME.PlaceholderText = "Название";
            TB_NAME.Size = new Size(219, 31);
            TB_NAME.TabIndex = 11;
            // 
            // TB_DESCRIPTION
            // 
            TB_DESCRIPTION.Location = new Point(31, 216);
            TB_DESCRIPTION.Margin = new Padding(4);
            TB_DESCRIPTION.Multiline = true;
            TB_DESCRIPTION.Name = "TB_DESCRIPTION";
            TB_DESCRIPTION.PlaceholderText = "Описание";
            TB_DESCRIPTION.Size = new Size(215, 214);
            TB_DESCRIPTION.TabIndex = 13;
            // 
            // TB_PRICE
            // 
            TB_PRICE.Location = new Point(254, 88);
            TB_PRICE.Margin = new Padding(4);
            TB_PRICE.Name = "TB_PRICE";
            TB_PRICE.PlaceholderText = "Цена";
            TB_PRICE.Size = new Size(168, 31);
            TB_PRICE.TabIndex = 15;
            // 
            // TB_WEIGHT
            // 
            TB_WEIGHT.Location = new Point(254, 127);
            TB_WEIGHT.Margin = new Padding(4);
            TB_WEIGHT.Name = "TB_WEIGHT";
            TB_WEIGHT.PlaceholderText = "Вес";
            TB_WEIGHT.Size = new Size(98, 31);
            TB_WEIGHT.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 134);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 20;
            label7.Text = "Категория";
            // 
            // CMB_CATEGORY
            // 
            CMB_CATEGORY.FormattingEnabled = true;
            CMB_CATEGORY.Location = new Point(27, 163);
            CMB_CATEGORY.Margin = new Padding(4);
            CMB_CATEGORY.Name = "CMB_CATEGORY";
            CMB_CATEGORY.Size = new Size(219, 33);
            CMB_CATEGORY.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(BTN_CLEAR_ANIMALS);
            panel1.Controls.Add(TB_ANIMALS);
            panel1.Controls.Add(CMB_CATEGORY);
            panel1.Controls.Add(BTN_ACTION);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(CMB_ANIMALS);
            panel1.Controls.Add(TB_WEIGHT);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TB_PRICE);
            panel1.Controls.Add(TB_DESCRIPTION);
            panel1.Controls.Add(TB_NAME);
            panel1.Location = new Point(240, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 538);
            panel1.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 130);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 23;
            label3.Text = "грамм";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(176, 12);
            label2.Name = "label2";
            label2.Size = new Size(145, 60);
            label2.TabIndex = 22;
            label2.Text = "Товар";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 564);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Товар";
            Load += ProductForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BTN_ACTION;
        private ComboBox CMB_ANIMALS;
        private Label label1;
        private TextBox TB_ANIMALS;
        private Button BTN_CLEAR_ANIMALS;
        private TextBox TB_NAME;
        private TextBox TB_DESCRIPTION;
        private TextBox TB_PRICE;
        private TextBox TB_WEIGHT;
        private Label label7;
        private ComboBox CMB_CATEGORY;
        private Panel panel1;
        private Label label2;
        private Label label3;
    }
}