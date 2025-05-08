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
            BTN_ADD.Location = new Point(13, 13);
            BTN_ADD.Margin = new Padding(4);
            BTN_ADD.Name = "BTN_ADD";
            BTN_ADD.RightToLeft = RightToLeft.No;
            BTN_ADD.Size = new Size(285, 63);
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
            BTN_EDIT.Location = new Point(329, 13);
            BTN_EDIT.Margin = new Padding(4);
            BTN_EDIT.Name = "BTN_EDIT";
            BTN_EDIT.RightToLeft = RightToLeft.No;
            BTN_EDIT.Size = new Size(309, 63);
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
            BTN_DELETE.Location = new Point(668, 13);
            BTN_DELETE.Margin = new Padding(4);
            BTN_DELETE.Name = "BTN_DELETE";
            BTN_DELETE.RightToLeft = RightToLeft.No;
            BTN_DELETE.Size = new Size(297, 63);
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
            DG_SCHEDULE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_SCHEDULE.Columns.AddRange(new DataGridViewColumn[] { Id, UserId, PHIO, Date, TimeStart, TimeEnd });
            DG_SCHEDULE.Location = new Point(12, 83);
            DG_SCHEDULE.Name = "DG_SCHEDULE";
            DG_SCHEDULE.RowHeadersWidth = 62;
            DG_SCHEDULE.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DG_SCHEDULE.Size = new Size(954, 449);
            DG_SCHEDULE.TabIndex = 7;
            // 
            // Id
            // 
            Id.HeaderText = "Ключ";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Width = 150;
            // 
            // UserId
            // 
            UserId.HeaderText = "ID работника";
            UserId.MinimumWidth = 8;
            UserId.Name = "UserId";
            UserId.Visible = false;
            UserId.Width = 150;
            // 
            // PHIO
            // 
            PHIO.HeaderText = "Работник";
            PHIO.MinimumWidth = 8;
            PHIO.Name = "PHIO";
            PHIO.Width = 150;
            // 
            // Date
            // 
            Date.HeaderText = "Дата";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.Width = 150;
            // 
            // TimeStart
            // 
            TimeStart.HeaderText = "Начало смены";
            TimeStart.MinimumWidth = 8;
            TimeStart.Name = "TimeStart";
            TimeStart.Width = 150;
            // 
            // TimeEnd
            // 
            TimeEnd.HeaderText = "Конец смены";
            TimeEnd.MinimumWidth = 8;
            TimeEnd.Name = "TimeEnd";
            TimeEnd.Width = 150;
            // 
            // ScheduleReestr
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 544);
            Controls.Add(DG_SCHEDULE);
            Controls.Add(BTN_DELETE);
            Controls.Add(BTN_EDIT);
            Controls.Add(BTN_ADD);
            MinimumSize = new Size(1000, 600);
            Name = "ScheduleReestr";
            Text = "ScheduleReestr";
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