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
            label1 = new Label();
            TB_NAME = new TextBox();
            TB_ADRESS = new TextBox();
            label2 = new Label();
            CMB_CITY = new ComboBox();
            label3 = new Label();
            BTN_ACTION = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 123);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // TB_NAME
            // 
            TB_NAME.Location = new Point(160, 122);
            TB_NAME.Name = "TB_NAME";
            TB_NAME.Size = new Size(208, 27);
            TB_NAME.TabIndex = 1;
            // 
            // TB_ADRESS
            // 
            TB_ADRESS.Location = new Point(160, 174);
            TB_ADRESS.Multiline = true;
            TB_ADRESS.Name = "TB_ADRESS";
            TB_ADRESS.Size = new Size(208, 71);
            TB_ADRESS.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 177);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 3;
            label2.Text = "Адрес";
            // 
            // CMB_CITY
            // 
            CMB_CITY.FormattingEnabled = true;
            CMB_CITY.Location = new Point(535, 122);
            CMB_CITY.Name = "CMB_CITY";
            CMB_CITY.Size = new Size(151, 28);
            CMB_CITY.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 125);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 5;
            label3.Text = "Город";
            // 
            // BTN_ACTION
            // 
            BTN_ACTION.Location = new Point(317, 332);
            BTN_ACTION.Name = "BTN_ACTION";
            BTN_ACTION.Size = new Size(160, 49);
            BTN_ACTION.TabIndex = 7;
            BTN_ACTION.Text = "Добавить/Изменить";
            BTN_ACTION.UseVisualStyleBackColor = true;
            BTN_ACTION.Click += BTN_ACTION_Click;
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_ACTION);
            Controls.Add(label3);
            Controls.Add(CMB_CITY);
            Controls.Add(label2);
            Controls.Add(TB_ADRESS);
            Controls.Add(TB_NAME);
            Controls.Add(label1);
            Name = "ShopForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Магазин";
            Load += ShopForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TB_NAME;
        private TextBox TB_ADRESS;
        private Label label2;
        private ComboBox CMB_CITY;
        private Label label3;
        private Button BTN_ACTION;
    }
}