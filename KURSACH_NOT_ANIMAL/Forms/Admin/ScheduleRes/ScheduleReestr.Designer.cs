namespace KURSACH_NOT_ANIMAL.Forms.Admin.ScheduleRes
{
    partial class ScheduleReestr
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
            BTN_ADD = new Button();
            BTN_EDIT = new Button();
            BTN_DELETE = new Button();
            DG_SCHEDULE = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            UserId = new DataGridViewTextBoxColumn();
            PHIO = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            TimeStart = new DataGridViewTextBoxColumn();
            TimeEnd = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DG_SCHEDULE).BeginInit();
            SuspendLayout();
            // 
            // BTN_ADD
            // 
            BTN_ADD.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_ADD.Image = Properties.Resources.AddIcon;
            BTN_ADD.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_ADD.Location = new Point(10, 10);
            BTN_ADD.Name = "BTN_ADD";
            BTN_ADD.RightToLeft = RightToLeft.No;
            BTN_ADD.Size = new Size(228, 50);
            BTN_ADD.TabIndex = 4;
            BTN_ADD.Text = "Добавить";
            BTN_ADD.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTN_ADD.UseVisualStyleBackColor = true;
            BTN_ADD.Click += BTN_ADD_Click;
            // 
            // BTN_EDIT
            // 
            BTN_EDIT.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_EDIT.Image = Properties.Resources.EditIcon;
            BTN_EDIT.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_EDIT.Location = new Point(263, 10);
            BTN_EDIT.Name = "BTN_EDIT";
            BTN_EDIT.RightToLeft = RightToLeft.No;
            BTN_EDIT.Size = new Size(247, 50);
            BTN_EDIT.TabIndex = 5;
            BTN_EDIT.Text = "Редактировать";
            BTN_EDIT.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTN_EDIT.UseVisualStyleBackColor = true;
            BTN_EDIT.Click += BTN_EDIT_Click;
            // 
            // BTN_DELETE
            // 
            BTN_DELETE.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BTN_DELETE.Image = Properties.Resources.DeleteIcon;
            BTN_DELETE.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_DELETE.Location = new Point(534, 10);
            BTN_DELETE.Name = "BTN_DELETE";
            BTN_DELETE.RightToLeft = RightToLeft.No;
            BTN_DELETE.Size = new Size(238, 50);
            BTN_DELETE.TabIndex = 6;
            BTN_DELETE.Text = "Удалить";
            BTN_DELETE.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTN_DELETE.UseVisualStyleBackColor = true;
            BTN_DELETE.Click += BTN_DELETE_Click;
            // 
            // DG_SCHEDULE
            // 
            DG_SCHEDULE.AllowUserToAddRows = false;
            DG_SCHEDULE.AllowUserToDeleteRows = false;
            DG_SCHEDULE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DG_SCHEDULE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_SCHEDULE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_SCHEDULE.Columns.AddRange(new DataGridViewColumn[] { Id, UserId, PHIO, Date, TimeStart, TimeEnd });
            DG_SCHEDULE.Location = new Point(10, 66);
            DG_SCHEDULE.Margin = new Padding(2);
            DG_SCHEDULE.Name = "DG_SCHEDULE";
            DG_SCHEDULE.RowHeadersWidth = 62;
            DG_SCHEDULE.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DG_SCHEDULE.Size = new Size(763, 359);
            DG_SCHEDULE.TabIndex = 7;
            // 
            // Id
            // 
            Id.HeaderText = "Ключ";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // UserId
            // 
            UserId.HeaderText = "ID работника";
            UserId.MinimumWidth = 8;
            UserId.Name = "UserId";
            UserId.Visible = false;
            // 
            // PHIO
            // 
            PHIO.HeaderText = "Работник";
            PHIO.MinimumWidth = 8;
            PHIO.Name = "PHIO";
            // 
            // Date
            // 
            Date.HeaderText = "Дата";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            // 
            // TimeStart
            // 
            TimeStart.HeaderText = "Начало смены";
            TimeStart.MinimumWidth = 8;
            TimeStart.Name = "TimeStart";
            // 
            // TimeEnd
            // 
            TimeEnd.HeaderText = "Конец смены";
            TimeEnd.MinimumWidth = 8;
            TimeEnd.Name = "TimeEnd";
            // 
            // ScheduleReestr
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 442);
            Controls.Add(DG_SCHEDULE);
            Controls.Add(BTN_DELETE);
            Controls.Add(BTN_EDIT);
            Controls.Add(BTN_ADD);
            Margin = new Padding(2);
            MinimumSize = new Size(804, 489);
            Name = "ScheduleReestr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Рабочий график";
            Load += ScheduleReestr_Load;
            ((System.ComponentModel.ISupportInitialize)DG_SCHEDULE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BTN_ADD;
        private Button BTN_EDIT;
        private Button BTN_DELETE;
        private DataGridView DG_SCHEDULE;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn PHIO;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn TimeStart;
        private DataGridViewTextBoxColumn TimeEnd;
    }
}