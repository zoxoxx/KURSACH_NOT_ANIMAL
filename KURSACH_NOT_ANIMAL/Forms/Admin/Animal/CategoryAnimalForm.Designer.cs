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
            label1 = new Label();
            label2 = new Label();
            TB_NAME = new TextBox();
            TB_DESCIPRION = new TextBox();
            BTN_ACTION = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 92);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Наименование";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 144);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Описание";
            // 
            // TB_NAME
            // 
            TB_NAME.Location = new Point(252, 91);
            TB_NAME.Name = "TB_NAME";
            TB_NAME.Size = new Size(366, 27);
            TB_NAME.TabIndex = 2;
            // 
            // TB_DESCIPRION
            // 
            TB_DESCIPRION.Location = new Point(252, 149);
            TB_DESCIPRION.Multiline = true;
            TB_DESCIPRION.Name = "TB_DESCIPRION";
            TB_DESCIPRION.Size = new Size(366, 191);
            TB_DESCIPRION.TabIndex = 3;
            // 
            // BTN_ACTION
            // 
            BTN_ACTION.Location = new Point(368, 379);
            BTN_ACTION.Name = "BTN_ACTION";
            BTN_ACTION.Size = new Size(149, 40);
            BTN_ACTION.TabIndex = 4;
            BTN_ACTION.Text = "Удалить/Добавить";
            BTN_ACTION.UseVisualStyleBackColor = true;
            BTN_ACTION.Click += BTN_ACTION_Click;
            // 
            // CategoryAnimalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_ACTION);
            Controls.Add(TB_DESCIPRION);
            Controls.Add(TB_NAME);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CategoryAnimalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Категории животных";
            Load += CategoryAnimalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TB_NAME;
        private TextBox TB_DESCIPRION;
        private Button BTN_ACTION;
    }
}