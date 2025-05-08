using KURSACH_NOT_ANIMAL.Classes.DbClasses;
using KURSACH_NOT_ANIMAL.Classes.ViewClasses;
using KURSACH_NOT_ANIMAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSACH_NOT_ANIMAL.Forms.Admin.Operations
{
    public partial class OperationsReestr : Form
    {
        private List<OperationView> operations;
        public OperationsReestr()
        {
            InitializeComponent();

            DG_OPERATIONS.Columns[0].DataPropertyName = "Id";
            DG_OPERATIONS.Columns[1].DataPropertyName = "Product";
            DG_OPERATIONS.Columns[2].DataPropertyName = "Count";
            DG_OPERATIONS.Columns[3].DataPropertyName = "Summa";
            DG_OPERATIONS.Columns[4].DataPropertyName = "Date";
            DG_OPERATIONS.Columns[5].DataPropertyName = "Time";
            DG_OPERATIONS.Columns[6].DataPropertyName = "ClientName";
            DG_OPERATIONS.Columns[7].DataPropertyName = "Status";
            DG_OPERATIONS.Columns[8].DataPropertyName = "UserName";

            Apply.Text = "✔";
            Return.Text = "🔄";
            Decline.Text = "❌";
            Apply.UseColumnTextForButtonValue = true;
            Return.UseColumnTextForButtonValue = true;
            Decline.UseColumnTextForButtonValue = true;

            DG_OPERATIONS.AllowUserToAddRows = false;
            DG_OPERATIONS.AutoGenerateColumns = false;
        }

        private void OperationsReestr_Load(object sender, EventArgs e)
        {
            DataGridLoad();
        }

        private void DataGridLoad()
        {
            operations = OperationFromDb.GetOperations();
            DG_OPERATIONS.DataSource = operations;
        }

        private void DG_OPERATIONS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || !(DG_OPERATIONS.Columns[e.ColumnIndex] is DataGridViewButtonColumn)) return;

            string columnName = DG_OPERATIONS.Columns[e.ColumnIndex].Name;

            OperationView operation = operations[e.RowIndex];

            switch (columnName)
            {
                case "Approve":
                    operation.Status = "Выполнено";
                    break;
                case "Return":
                    operation.Status = "Возврат";
                    break;
                case "Decline":
                    operation.Status = "Отмена";
                    break;
                default:
                    return;
            }

            DG_OPERATIONS.Rows[e.RowIndex].Cells["Status"].Value = operation.Status;

            DisableActionButtons(e.RowIndex);

            OperationFromDb.UpdateOperation(operation);
        }

        private void DisableActionButtons(int rowIndex)
        {
            foreach (string buttonColumn in new[] { "Approve", "Return", "Decline" })
            {
                var cell = DG_OPERATIONS.Rows[rowIndex].Cells[buttonColumn] as DataGridViewButtonCell;
                if (cell != null)
                {
                    cell.ReadOnly = true;
                    cell.Style.ForeColor = Color.Gray;
                    cell.Style.SelectionForeColor = Color.Gray;
                }
            }
        }
    }
}
