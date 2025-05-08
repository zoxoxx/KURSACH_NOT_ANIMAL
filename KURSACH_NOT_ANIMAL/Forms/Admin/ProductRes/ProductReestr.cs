using KURSACH_NOT_ANIMAL.Classes.DbClasses;
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

namespace KURSACH_NOT_ANIMAL.Forms.Admin.ProductRes
{
    public partial class ProductReestr : Form
    {
        List<ProductView>? products;
        List<CategoryProduct>? categories = new List<CategoryProduct>();
        private int editableRowIndex = -1;
        public ProductReestr()
        {
            InitializeComponent();

            DG_PRODUCTS.Columns[0].DataPropertyName = "Id";
            DG_PRODUCTS.Columns[1].DataPropertyName = "Name";
            DG_PRODUCTS.Columns[2].DataPropertyName = "Weight";
            DG_PRODUCTS.Columns[3].DataPropertyName = "Price";
            DG_PRODUCTS.Columns[4].DataPropertyName = "CategoryName";
            DG_PRODUCTS.Columns[5].DataPropertyName = "Description";
            DG_PRODUCTS.Columns[6].DataPropertyName = "Commentary";
            DG_PRODUCTS.Columns[7].DataPropertyName = "CategoryId";

            DG_PRODUCTS.AllowUserToAddRows = false;
            DG_PRODUCTS.EditMode = DataGridViewEditMode.EditOnEnter;
            DG_PRODUCTS.AutoGenerateColumns = false;
        }


    }
}
