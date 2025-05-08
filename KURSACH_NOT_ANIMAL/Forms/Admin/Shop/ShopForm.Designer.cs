namespace KURSACH_NOT_ANIMAL.Forms.Admin.Shop
{
    partial class ShopForm
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
            TB_NAME = new TextBox();
            TB_ADRESS = new TextBox();
            CMB_CITY = new ComboBox();
            BTN_ACTION = new Button();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TB_NAME
            // 
            TB_NAME.Location = new Point(43, 106);
            TB_NAME.Margin = new Padding(4);
            TB_NAME.Name = "TB_NAME";
            TB_NAME.PlaceholderText = "Имя";
            TB_NAME.Size = new Size(259, 31);
            TB_NAME.TabIndex = 1;
            // 
            // TB_ADRESS
            // 
            TB_ADRESS.Location = new Point(43, 236);
            TB_ADRESS.Margin = new Padding(4);
            TB_ADRESS.Multiline = true;
            TB_ADRESS.Name = "TB_ADRESS";
            TB_ADRESS.PlaceholderText = "Адрес";
            TB_ADRESS.Size = new Size(259, 88);
            TB_ADRESS.TabIndex = 2;
            // 
            // CMB_CITY
            // 
            CMB_CITY.FormattingEnabled = true;
            CMB_CITY.Location = new Point(43, 183);
            CMB_CITY.Margin = new Padding(4);
            CMB_CITY.Name = "CMB_CITY";
            CMB_CITY.Size = new Size(259, 33);
            CMB_CITY.TabIndex = 4;
            // 
            // BTN_ACTION
            // 
            BTN_ACTION.BackColor = SystemColors.ActiveBorder;
            BTN_ACTION.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_ACTION.Location = new Point(43, 363);
            BTN_ACTION.Margin = new Padding(4);
            BTN_ACTION.Name = "BTN_ACTION";
            BTN_ACTION.Size = new Size(259, 61);
            BTN_ACTION.TabIndex = 7;
            BTN_ACTION.Text = "Изменить/Добавить";
            BTN_ACTION.UseVisualStyleBackColor = false;
            BTN_ACTION.Click += BTN_ACTION_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 154);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 5;
            label3.Text = "Город";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TB_ADRESS);
            panel1.Controls.Add(BTN_ACTION);
            panel1.Controls.Add(TB_NAME);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(CMB_CITY);
            panel1.Location = new Point(311, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 461);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(71, 21);
            label1.Name = "label1";
            label1.Size = new Size(196, 60);
            label1.TabIndex = 8;
            label1.Text = "Партнер";
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 544);
            Controls.Add(panel1);
            Margin = new Padding(4);
            MinimumSize = new Size(1000, 600);
            Name = "ShopForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Магазин партнер";
            Load += ShopForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox TB_NAME;
        private TextBox TB_ADRESS;
        private ComboBox CMB_CITY;
        private Button BTN_ACTION;
        private Label label3;
        private Panel panel1;
        private Label label1;
    }
}