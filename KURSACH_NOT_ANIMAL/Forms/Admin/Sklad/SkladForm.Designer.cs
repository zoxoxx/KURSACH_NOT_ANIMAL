namespace KURSACH_NOT_ANIMAL.Forms.Admin.Sklad
{
    partial class SkladForm
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
            label1 = new Label();
            TB_COUNT = new TextBox();
            label2 = new Label();
            CMB_PRODUCT = new ComboBox();
            label3 = new Label();
            TB_PRICE = new TextBox();
            label4 = new Label();
            CMB_PARTNER = new ComboBox();
            label5 = new Label();
            LBL_DATE = new Label();
            label6 = new Label();
            CMB_SHOP = new ComboBox();
            SuspendLayout();
            // 
            // BTN_ACTION
            // 
            BTN_ACTION.Location = new Point(313, 339);
            BTN_ACTION.Name = "BTN_ACTION";
            BTN_ACTION.Size = new Size(166, 38);
            BTN_ACTION.TabIndex = 0;
            BTN_ACTION.Text = "Добавить/Изменить";
            BTN_ACTION.UseVisualStyleBackColor = true;
            BTN_ACTION.Click += BTN_ACTION_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 138);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 1;
            label1.Text = "Количество";
            // 
            // TB_COUNT
            // 
            TB_COUNT.Location = new Point(124, 138);
            TB_COUNT.Name = "TB_COUNT";
            TB_COUNT.Size = new Size(166, 27);
            TB_COUNT.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 190);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 3;
            label2.Text = "Товар";
            // 
            // CMB_PRODUCT
            // 
            CMB_PRODUCT.FormattingEnabled = true;
            CMB_PRODUCT.Location = new Point(124, 190);
            CMB_PRODUCT.Name = "CMB_PRODUCT";
            CMB_PRODUCT.Size = new Size(166, 28);
            CMB_PRODUCT.TabIndex = 4;
            // 
            // label3
            // 
            label3.Location = new Point(327, 137);
            label3.Name = "label3";
            label3.Size = new Size(71, 44);
            label3.TabIndex = 5;
            label3.Text = "Цена закупки";
            // 
            // TB_PRICE
            // 
            TB_PRICE.Location = new Point(430, 140);
            TB_PRICE.Name = "TB_PRICE";
            TB_PRICE.Size = new Size(151, 27);
            TB_PRICE.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 192);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 7;
            label4.Text = "Поставщик";
            // 
            // CMB_PARTNER
            // 
            CMB_PARTNER.FormattingEnabled = true;
            CMB_PARTNER.Location = new Point(430, 189);
            CMB_PARTNER.Name = "CMB_PARTNER";
            CMB_PARTNER.Size = new Size(151, 28);
            CMB_PARTNER.TabIndex = 8;
            // 
            // label5
            // 
            label5.Location = new Point(622, 139);
            label5.Name = "label5";
            label5.Size = new Size(68, 42);
            label5.TabIndex = 9;
            label5.Text = "Дата закупки";
            // 
            // LBL_DATE
            // 
            LBL_DATE.AutoSize = true;
            LBL_DATE.Location = new Point(710, 147);
            LBL_DATE.Name = "LBL_DATE";
            LBL_DATE.Size = new Size(41, 20);
            LBL_DATE.TabIndex = 10;
            LBL_DATE.Text = "Дата";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(624, 194);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 11;
            label6.Text = "Магазин";
            // 
            // CMB_SHOP
            // 
            CMB_SHOP.FormattingEnabled = true;
            CMB_SHOP.Location = new Point(710, 189);
            CMB_SHOP.Name = "CMB_SHOP";
            CMB_SHOP.Size = new Size(151, 28);
            CMB_SHOP.TabIndex = 12;
            // 
            // SkladForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 450);
            Controls.Add(CMB_SHOP);
            Controls.Add(label6);
            Controls.Add(LBL_DATE);
            Controls.Add(label5);
            Controls.Add(CMB_PARTNER);
            Controls.Add(label4);
            Controls.Add(TB_PRICE);
            Controls.Add(label3);
            Controls.Add(CMB_PRODUCT);
            Controls.Add(label2);
            Controls.Add(TB_COUNT);
            Controls.Add(label1);
            Controls.Add(BTN_ACTION);
            Name = "SkladForm";
            Text = "Закупка";
            Load += SkladForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_ACTION;
        private Label label1;
        private TextBox TB_COUNT;
        private Label label2;
        private ComboBox CMB_PRODUCT;
        private Label label3;
        private TextBox TB_PRICE;
        private Label label4;
        private ComboBox CMB_PARTNER;
        private Label label5;
        private Label LBL_DATE;
        private Label label6;
        private ComboBox CMB_SHOP;
    }
}