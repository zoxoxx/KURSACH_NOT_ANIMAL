using KURSACH_NOT_ANIMAL.Classes.DbClasses;
using KURSACH_NOT_ANIMAL.Classes.SystemClasses;
using KURSACH_NOT_ANIMAL.Classes.ViewClasses;
using KURSACH_NOT_ANIMAL.Forms.Admin.Sklad;
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

namespace KURSACH_NOT_ANIMAL.Forms.Admin.ProductRes
{
    public partial class ProductReestr : Form
    {
        List<ProductView>? products;
        public ProductReestr()
        {
            InitializeComponent();

            this.DG_PRODUCTS.Columns[0].DataPropertyName = "Id";
            this.DG_PRODUCTS.Columns[1].DataPropertyName = "Name";
            this.DG_PRODUCTS.Columns[2].DataPropertyName = "Weight";
            this.DG_PRODUCTS.Columns[3].DataPropertyName = "Price";
            this.DG_PRODUCTS.Columns[4].DataPropertyName = "CategoryName";
            this.DG_PRODUCTS.Columns[5].DataPropertyName = "Description";
            this.DG_PRODUCTS.Columns[6].DataPropertyName = "Commentary";
            this.DG_PRODUCTS.Columns[7].DataPropertyName = "CategoryId";

            this.DG_PRODUCTS.AutoGenerateColumns = false;
        }

        private void ProductReestr_Load(object sender, EventArgs e)
        {
            DataGridLoad();
        }

        private void DataGridLoad()
        {
            products = ProductFromDb.GetProductsWithCategory();
            this.DG_PRODUCTS.DataSource = products;
            DG_PRODUCTS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm(flagInsert: true);
            this.Hide();
            productForm.ShowDialog();
            this.Show();

            DataGridLoad();
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            ProductView? selectedProduct = this.DG_PRODUCTS.CurrentRow.DataBoundItem as ProductView;

            if (selectedProduct is null)
                return;

            bool result;
            result = ProductFromDb.DeleteRecomendationsForProduct(selectedProduct.Id);
            result = ProductFromDb.DeleteProduct(selectedProduct.Id);

            if (result)
                Logger.Log($"Был удален продукт из справочника с наименованием: '{selectedProduct.Name}', пользователем {MainForm.CurrentUser.PHYO ?? "Тестовый пользователь"}.");

            DataGridLoad();
        }

        private void DG_PRODUCTS_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductView? selectedProduct = this.DG_PRODUCTS.CurrentRow.DataBoundItem as ProductView;

            if (selectedProduct is null)
                return;

            ProductForm productForm = new ProductForm(flagUpdate: true, product: selectedProduct);
            this.Hide();
            productForm.ShowDialog();
            this.Show();

            DataGridLoad();
        }
    }
}
