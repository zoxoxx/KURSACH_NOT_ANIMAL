namespace KURSACH_NOT_ANIMAL.Forms.Admin.Operations
{
    partial class OperationsReestr
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
            DG_OPERATIONS = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            Count = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            User = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Worker = new DataGridViewTextBoxColumn();
            Apply = new DataGridViewButtonColumn();
            Return = new DataGridViewButtonColumn();
            Decline = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)DG_OPERATIONS).BeginInit();
            SuspendLayout();
            // 
            // DG_OPERATIONS
            // 
            DG_OPERATIONS.AllowUserToAddRows = false;
            DG_OPERATIONS.AllowUserToDeleteRows = false;
            DG_OPERATIONS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_OPERATIONS.Columns.AddRange(new DataGridViewColumn[] { Id, Product, Count, Price, Date, Time, User, Status, Worker, Apply, Return, Decline });
            DG_OPERATIONS.Location = new Point(12, 12);
            DG_OPERATIONS.Name = "DG_OPERATIONS";
            DG_OPERATIONS.ReadOnly = true;
            DG_OPERATIONS.RowHeadersWidth = 62;
            DG_OPERATIONS.Size = new Size(1365, 666);
            DG_OPERATIONS.TabIndex = 0;
            DG_OPERATIONS.CellContentClick += DG_OPERATIONS_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 150;
            // 
            // Product
            // 
            Product.HeaderText = "Товар";
            Product.MinimumWidth = 8;
            Product.Name = "Product";
            Product.ReadOnly = true;
            Product.Width = 150;
            // 
            // Count
            // 
            Count.HeaderText = "Количество";
            Count.MinimumWidth = 8;
            Count.Name = "Count";
            Count.ReadOnly = true;
            Count.Width = 150;
            // 
            // Price
            // 
            Price.HeaderText = "Стоимость";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 150;
            // 
            // Date
            // 
            Date.HeaderText = "Дата";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 150;
            // 
            // Time
            // 
            Time.HeaderText = "Время";
            Time.MinimumWidth = 8;
            Time.Name = "Time";
            Time.ReadOnly = true;
            Time.Width = 150;
            // 
            // User
            // 
            User.HeaderText = "Клиент";
            User.MinimumWidth = 8;
            User.Name = "User";
            User.ReadOnly = true;
            User.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Статус";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 150;
            // 
            // Worker
            // 
            Worker.HeaderText = "Обработал";
            Worker.MinimumWidth = 8;
            Worker.Name = "Worker";
            Worker.ReadOnly = true;
            Worker.Visible = false;
            Worker.Width = 150;
            // 
            // Apply
            // 
            Apply.HeaderText = "";
            Apply.MinimumWidth = 8;
            Apply.Name = "Apply";
            Apply.ReadOnly = true;
            Apply.Text = "";
            Apply.Width = 50;
            // 
            // Return
            // 
            Return.HeaderText = "";
            Return.MinimumWidth = 8;
            Return.Name = "Return";
            Return.ReadOnly = true;
            Return.Width = 50;
            // 
            // Decline
            // 
            Decline.HeaderText = "";
            Decline.MinimumWidth = 8;
            Decline.Name = "Decline";
            Decline.ReadOnly = true;
            Decline.Width = 50;
            // 
            // OperationsReestr
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 690);
            Controls.Add(DG_OPERATIONS);
            Name = "OperationsReestr";
            Text = "Операции";
            Load += OperationsReestr_Load;
            ((System.ComponentModel.ISupportInitialize)DG_OPERATIONS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DG_OPERATIONS;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Worker;
        private DataGridViewButtonColumn Apply;
        private DataGridViewButtonColumn Return;
        private DataGridViewButtonColumn Decline;
    }
}