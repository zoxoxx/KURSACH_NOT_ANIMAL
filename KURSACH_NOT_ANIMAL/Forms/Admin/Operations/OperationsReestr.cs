using KURSACH_NOT_ANIMAL.Classes.ViewClasses;
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
        }
    }
}
