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
            label1 = new Label();
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 0;
            label1.Text = "Наименование товара";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 80);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 2;
            label2.Text = "Вес";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(400, 26);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 4;
            label3.Text = "Цена";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 83);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 6;
            label4.Text = "Описание";
            // 
            // TB_DESCRIPTION
            // 
            TB_DESCRIPTION.Location = new Point(198, 83);
            TB_DESCRIPTION.Multiline = true;
            TB_DESCRIPTION.Name = "TB_DESCRIPTION";
            TB_DESCRIPTION.ReadOnly = true;
            TB_DESCRIPTION.Size = new Size(190, 133);
            TB_DESCRIPTION.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 307);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 8;
            label5.Text = "Итоговая цена";
            // 
            // TB_FINAL_PRICE
            // 
            TB_FINAL_PRICE.Location = new Point(349, 307);
            TB_FINAL_PRICE.Name = "TB_FINAL_PRICE";
            TB_FINAL_PRICE.ReadOnly = true;
            TB_FINAL_PRICE.Size = new Size(125, 27);
            TB_FINAL_PRICE.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(198, 265);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 10;
            label6.Text = "Количество";
            // 
            // TB_COUNT
            // 
            TB_COUNT.Location = new Point(349, 262);
            TB_COUNT.Name = "TB_COUNT";
            TB_COUNT.Size = new Size(125, 27);
            TB_COUNT.TabIndex = 11;
            TB_COUNT.TextChanged += TB_COUNT_TextChanged;
            TB_COUNT.Enter += TB_COUNT_Enter;
            // 
            // BTN_CREATE_OPERATION
            // 
            BTN_CREATE_OPERATION.BackColor = SystemColors.ActiveBorder;
            BTN_CREATE_OPERATION.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_CREATE_OPERATION.Location = new Point(251, 364);
            BTN_CREATE_OPERATION.Name = "BTN_CREATE_OPERATION";
            BTN_CREATE_OPERATION.Size = new Size(301, 51);
            BTN_CREATE_OPERATION.TabIndex = 12;
            BTN_CREATE_OPERATION.Text = "Оставить заявку";
            BTN_CREATE_OPERATION.UseVisualStyleBackColor = false;
            BTN_CREATE_OPERATION.Click += BTN_CREATE_OPERATION_Click;
            // 
            // LBL_NAME
            // 
            LBL_NAME.AutoSize = true;
            LBL_NAME.Location = new Point(198, 25);
            LBL_NAME.Name = "LBL_NAME";
            LBL_NAME.Size = new Size(116, 20);
            LBL_NAME.TabIndex = 13;
            LBL_NAME.Text = "Наименование";
            // 
            // LBL_PRICE
            // 
            LBL_PRICE.AutoSize = true;
            LBL_PRICE.Location = new Point(461, 28);
            LBL_PRICE.Name = "LBL_PRICE";
            LBL_PRICE.Size = new Size(76, 20);
            LBL_PRICE.TabIndex = 14;
            LBL_PRICE.Text = "Значение";
            // 
            // LBL_WEIGHT
            // 
            LBL_WEIGHT.AutoSize = true;
            LBL_WEIGHT.Location = new Point(458, 81);
            LBL_WEIGHT.Name = "LBL_WEIGHT";
            LBL_WEIGHT.Size = new Size(76, 20);
            LBL_WEIGHT.TabIndex = 15;
            LBL_WEIGHT.Text = "Значение";
            // 
            // OperationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LBL_WEIGHT);
            Controls.Add(LBL_PRICE);
            Controls.Add(LBL_NAME);
            Controls.Add(BTN_CREATE_OPERATION);
            Controls.Add(TB_COUNT);
            Controls.Add(label6);
            Controls.Add(TB_FINAL_PRICE);
            Controls.Add(label5);
            Controls.Add(TB_DESCRIPTION);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OperationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Новая заявка";
            Load += OperationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
    }
}