﻿namespace KURSACH_NOT_ANIMAL.Forms.Admin.ScheduleRes
{
    partial class ScheduleForm
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
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BTN_SAVE = new Button();
            DTP_END = new DateTimePicker();
            DTP_START = new DateTimePicker();
            DTP_DATE = new DateTimePicker();
            CB_USER = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BTN_SAVE);
            panel1.Controls.Add(DTP_END);
            panel1.Controls.Add(DTP_START);
            panel1.Controls.Add(DTP_DATE);
            panel1.Controls.Add(CB_USER);
            panel1.Location = new Point(206, 34);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 362);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Location = new Point(22, 218);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 41);
            label5.TabIndex = 9;
            label5.Text = "Конец смены";
            // 
            // label4
            // 
            label4.Location = new Point(22, 167);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 41);
            label4.TabIndex = 8;
            label4.Text = "Начало смены";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 135);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 7;
            label3.Text = "Дата";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 92);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 6;
            label2.Text = "Работник";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(18, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(349, 50);
            label1.TabIndex = 5;
            label1.Text = "Запись расписания";
            // 
            // BTN_SAVE
            // 
            BTN_SAVE.BackColor = SystemColors.ActiveBorder;
            BTN_SAVE.Location = new Point(23, 287);
            BTN_SAVE.Margin = new Padding(2, 2, 2, 2);
            BTN_SAVE.Name = "BTN_SAVE";
            BTN_SAVE.Size = new Size(314, 50);
            BTN_SAVE.TabIndex = 4;
            BTN_SAVE.Text = "Сохранить";
            BTN_SAVE.UseVisualStyleBackColor = false;
            BTN_SAVE.Click += BTN_SAVE_Click;
            // 
            // DTP_END
            // 
            DTP_END.Anchor = AnchorStyles.None;
            DTP_END.Format = DateTimePickerFormat.Time;
            DTP_END.Location = new Point(97, 234);
            DTP_END.Margin = new Padding(2, 2, 2, 2);
            DTP_END.Name = "DTP_END";
            DTP_END.ShowUpDown = true;
            DTP_END.Size = new Size(241, 27);
            DTP_END.TabIndex = 3;
            // 
            // DTP_START
            // 
            DTP_START.Anchor = AnchorStyles.None;
            DTP_START.Format = DateTimePickerFormat.Time;
            DTP_START.Location = new Point(97, 183);
            DTP_START.Margin = new Padding(2, 2, 2, 2);
            DTP_START.Name = "DTP_START";
            DTP_START.ShowUpDown = true;
            DTP_START.Size = new Size(241, 27);
            DTP_START.TabIndex = 2;
            // 
            // DTP_DATE
            // 
            DTP_DATE.Anchor = AnchorStyles.None;
            DTP_DATE.Location = new Point(98, 131);
            DTP_DATE.Margin = new Padding(2, 2, 2, 2);
            DTP_DATE.Name = "DTP_DATE";
            DTP_DATE.Size = new Size(240, 27);
            DTP_DATE.TabIndex = 1;
            // 
            // CB_USER
            // 
            CB_USER.Anchor = AnchorStyles.None;
            CB_USER.Location = new Point(97, 90);
            CB_USER.Margin = new Padding(2, 2, 2, 2);
            CB_USER.Name = "CB_USER";
            CB_USER.Size = new Size(240, 28);
            CB_USER.TabIndex = 0;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 442);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(804, 489);
            Name = "ScheduleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Запись расписания";
            Load += ScheduleForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker DTP_END;
        private DateTimePicker DTP_START;
        private DateTimePicker DTP_DATE;
        private ComboBox CB_USER;
        private Label label2;
        private Label label1;
        private Button BTN_SAVE;
        private Label label4;
        private Label label3;
        private Label label5;
    }
}