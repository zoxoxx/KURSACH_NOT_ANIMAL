namespace KURSACH_NOT_ANIMAL.Forms.Client.OperationRes
{
    partial class OperationForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TB_DESCRIPTION = new TextBox();
            label5 = new Label();
            TB_FINAL_PRICE = new TextBox();
            label6 = new Label();
            TB_COUNT = new TextBox();
            BTN_CREATE_OPERATION = new Button();
            LBL_NAME = new Label();
            LBL_PRICE = new Label();
            LBL_WEIGHT = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 139);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 2;
            label2.Text = "Вес:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 139);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 4;
            label3.Text = "Цена:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 192);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 6;
            label4.Text = "Описание";
            // 
            // TB_DESCRIPTION
            // 
            TB_DESCRIPTION.Location = new Point(48, 221);
            TB_DESCRIPTION.Margin = new Padding(4);
            TB_DESCRIPTION.Multiline = true;
            TB_DESCRIPTION.Name = "TB_DESCRIPTION";
            TB_DESCRIPTION.ReadOnly = true;
            TB_DESCRIPTION.Size = new Size(414, 99);
            TB_DESCRIPTION.TabIndex = 7;
            TB_DESCRIPTION.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 357);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 8;
            label5.Text = "Итоговая цена";
            // 
            // TB_FINAL_PRICE
            // 
            TB_FINAL_PRICE.Location = new Point(307, 386);
            TB_FINAL_PRICE.Margin = new Padding(4);
            TB_FINAL_PRICE.Name = "TB_FINAL_PRICE";
            TB_FINAL_PRICE.ReadOnly = true;
            TB_FINAL_PRICE.Size = new Size(155, 31);
            TB_FINAL_PRICE.TabIndex = 9;
            TB_FINAL_PRICE.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 357);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 10;
            label6.Text = "Количество";
            // 
            // TB_COUNT
            // 
            TB_COUNT.Location = new Point(48, 386);
            TB_COUNT.Margin = new Padding(4);
            TB_COUNT.Name = "TB_COUNT";
            TB_COUNT.Size = new Size(157, 31);
            TB_COUNT.TabIndex = 11;
            TB_COUNT.Text = "0";
            TB_COUNT.TextChanged += TB_COUNT_TextChanged;
            TB_COUNT.Enter += TB_COUNT_Enter;
            // 
            // BTN_CREATE_OPERATION
            // 
            BTN_CREATE_OPERATION.BackColor = SystemColors.ActiveBorder;
            BTN_CREATE_OPERATION.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_CREATE_OPERATION.Location = new Point(48, 437);
            BTN_CREATE_OPERATION.Margin = new Padding(4);
            BTN_CREATE_OPERATION.Name = "BTN_CREATE_OPERATION";
            BTN_CREATE_OPERATION.Size = new Size(414, 64);
            BTN_CREATE_OPERATION.TabIndex = 12;
            BTN_CREATE_OPERATION.Text = "Оставить заявку";
            BTN_CREATE_OPERATION.UseVisualStyleBackColor = false;
            BTN_CREATE_OPERATION.Click += BTN_CREATE_OPERATION_Click;
            // 
            // LBL_NAME
            // 
            LBL_NAME.AutoSize = true;
            LBL_NAME.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LBL_NAME.Location = new Point(45, 44);
            LBL_NAME.Margin = new Padding(4, 0, 4, 0);
            LBL_NAME.Name = "LBL_NAME";
            LBL_NAME.Size = new Size(181, 32);
            LBL_NAME.TabIndex = 13;
            LBL_NAME.Text = "Наименование";
            // 
            // LBL_PRICE
            // 
            LBL_PRICE.AutoSize = true;
            LBL_PRICE.Location = new Point(106, 139);
            LBL_PRICE.Margin = new Padding(4, 0, 4, 0);
            LBL_PRICE.Name = "LBL_PRICE";
            LBL_PRICE.Size = new Size(89, 25);
            LBL_PRICE.TabIndex = 14;
            LBL_PRICE.Text = "Значение";
            // 
            // LBL_WEIGHT
            // 
            LBL_WEIGHT.AutoSize = true;
            LBL_WEIGHT.Location = new Point(307, 139);
            LBL_WEIGHT.Margin = new Padding(4, 0, 4, 0);
            LBL_WEIGHT.Name = "LBL_WEIGHT";
            LBL_WEIGHT.Size = new Size(89, 25);
            LBL_WEIGHT.TabIndex = 15;
            LBL_WEIGHT.Text = "Значение";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(TB_DESCRIPTION);
            panel1.Controls.Add(LBL_WEIGHT);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(LBL_PRICE);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(LBL_NAME);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(BTN_CREATE_OPERATION);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TB_COUNT);
            panel1.Controls.Add(TB_FINAL_PRICE);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(239, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 528);
            panel1.TabIndex = 16;
            // 
            // OperationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "OperationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Новая заявка";
            Load += OperationForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TB_DESCRIPTION;
        private Label label5;
        private TextBox TB_FINAL_PRICE;
        private Label label6;
        private TextBox TB_COUNT;
        private Button BTN_CREATE_OPERATION;
        private Label LBL_NAME;
        private Label LBL_PRICE;
        private Label LBL_WEIGHT;
        private Panel panel1;
    }
}