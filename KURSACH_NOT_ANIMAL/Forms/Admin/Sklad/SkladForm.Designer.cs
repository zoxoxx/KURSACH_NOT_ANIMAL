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
            TB_COUNT = new TextBox();
            label2 = new Label();
            CMB_PRODUCT = new ComboBox();
            TB_PRICE = new TextBox();
            label4 = new Label();
            CMB_PARTNER = new ComboBox();
            label5 = new Label();
            LBL_DATE = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BTN_ACTION
            // 
            BTN_ACTION.Anchor = AnchorStyles.None;
            BTN_ACTION.BackColor = SystemColors.ActiveBorder;
            BTN_ACTION.Location = new Point(21, 362);
            BTN_ACTION.Margin = new Padding(4);
            BTN_ACTION.Name = "BTN_ACTION";
            BTN_ACTION.Size = new Size(438, 72);
            BTN_ACTION.TabIndex = 0;
            BTN_ACTION.Text = "Добавить/Изменить";
            BTN_ACTION.UseVisualStyleBackColor = false;
            BTN_ACTION.Click += BTN_ACTION_Click;
            // 
            // TB_COUNT
            // 
            TB_COUNT.Anchor = AnchorStyles.None;
            TB_COUNT.Location = new Point(21, 220);
            TB_COUNT.Margin = new Padding(4);
            TB_COUNT.Name = "TB_COUNT";
            TB_COUNT.PlaceholderText = "Количество";
            TB_COUNT.Size = new Size(206, 31);
            TB_COUNT.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(21, 124);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 3;
            label2.Text = "Товар";
            // 
            // CMB_PRODUCT
            // 
            CMB_PRODUCT.Anchor = AnchorStyles.None;
            CMB_PRODUCT.FormattingEnabled = true;
            CMB_PRODUCT.Location = new Point(21, 153);
            CMB_PRODUCT.Margin = new Padding(4);
            CMB_PRODUCT.Name = "CMB_PRODUCT";
            CMB_PRODUCT.Size = new Size(206, 33);
            CMB_PRODUCT.TabIndex = 4;
            // 
            // TB_PRICE
            // 
            TB_PRICE.Anchor = AnchorStyles.None;
            TB_PRICE.Location = new Point(253, 220);
            TB_PRICE.Margin = new Padding(4);
            TB_PRICE.Name = "TB_PRICE";
            TB_PRICE.PlaceholderText = "Стоимость";
            TB_PRICE.Size = new Size(206, 31);
            TB_PRICE.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(257, 124);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 7;
            label4.Text = "Поставщик";
            // 
            // CMB_PARTNER
            // 
            CMB_PARTNER.Anchor = AnchorStyles.None;
            CMB_PARTNER.FormattingEnabled = true;
            CMB_PARTNER.Location = new Point(253, 153);
            CMB_PARTNER.Margin = new Padding(4);
            CMB_PARTNER.Name = "CMB_PARTNER";
            CMB_PARTNER.Size = new Size(206, 33);
            CMB_PARTNER.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Location = new Point(253, 279);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 52);
            label5.TabIndex = 9;
            label5.Text = "Дата закупки";
            // 
            // LBL_DATE
            // 
            LBL_DATE.Anchor = AnchorStyles.None;
            LBL_DATE.AutoSize = true;
            LBL_DATE.Location = new Point(346, 294);
            LBL_DATE.Margin = new Padding(4, 0, 4, 0);
            LBL_DATE.Name = "LBL_DATE";
            LBL_DATE.Size = new Size(49, 25);
            LBL_DATE.TabIndex = 10;
            LBL_DATE.Text = "Дата";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TB_PRICE);
            panel1.Controls.Add(BTN_ACTION);
            panel1.Controls.Add(TB_COUNT);
            panel1.Controls.Add(LBL_DATE);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(CMB_PRODUCT);
            panel1.Controls.Add(CMB_PARTNER);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(307, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 472);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(145, 23);
            label1.Name = "label1";
            label1.Size = new Size(183, 60);
            label1.TabIndex = 13;
            label1.Text = "Закупка";
            // 
            // SkladForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 562);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "SkladForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Закупка";
            Load += SkladForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BTN_ACTION;
        private TextBox TB_COUNT;
        private Label label2;
        private ComboBox CMB_PRODUCT;
        private TextBox TB_PRICE;
        private Label label4;
        private ComboBox CMB_PARTNER;
        private Label label5;
        private Label LBL_DATE;
        private Panel panel1;
        private Label label1;
    }
}