namespace KURSACH_NOT_ANIMAL.Forms.Animal
{
    partial class CategoryAnimalForm
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
            TB_DESCIPRION = new TextBox();
            BTN_ACTION = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TB_NAME
            // 
            TB_NAME.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TB_NAME.Location = new Point(54, 105);
            TB_NAME.Margin = new Padding(4);
            TB_NAME.Name = "TB_NAME";
            TB_NAME.PlaceholderText = "Название категории";
            TB_NAME.Size = new Size(376, 39);
            TB_NAME.TabIndex = 2;
            // 
            // TB_DESCIPRION
            // 
            TB_DESCIPRION.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TB_DESCIPRION.Location = new Point(54, 162);
            TB_DESCIPRION.Margin = new Padding(4);
            TB_DESCIPRION.Multiline = true;
            TB_DESCIPRION.Name = "TB_DESCIPRION";
            TB_DESCIPRION.PlaceholderText = "Описание";
            TB_DESCIPRION.Size = new Size(376, 238);
            TB_DESCIPRION.TabIndex = 3;
            // 
            // BTN_ACTION
            // 
            BTN_ACTION.BackColor = SystemColors.ActiveBorder;
            BTN_ACTION.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_ACTION.Location = new Point(54, 424);
            BTN_ACTION.Margin = new Padding(4);
            BTN_ACTION.Name = "BTN_ACTION";
            BTN_ACTION.Size = new Size(376, 64);
            BTN_ACTION.TabIndex = 4;
            BTN_ACTION.Text = "Удалить/Добавить";
            BTN_ACTION.UseVisualStyleBackColor = false;
            BTN_ACTION.Click += BTN_ACTION_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TB_DESCIPRION);
            panel1.Controls.Add(BTN_ACTION);
            panel1.Controls.Add(TB_NAME);
            panel1.Location = new Point(232, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 505);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(123, 23);
            label1.Name = "label1";
            label1.Size = new Size(231, 60);
            label1.TabIndex = 5;
            label1.Text = "Категория";
            // 
            // CategoryAnimalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 544);
            Controls.Add(panel1);
            Margin = new Padding(4);
            MinimumSize = new Size(1000, 600);
            Name = "CategoryAnimalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Категории животных";
            Load += CategoryAnimalForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox TB_NAME;
        private TextBox TB_DESCIPRION;
        private Button BTN_ACTION;
        private Panel panel1;
        private Label label1;
    }
}