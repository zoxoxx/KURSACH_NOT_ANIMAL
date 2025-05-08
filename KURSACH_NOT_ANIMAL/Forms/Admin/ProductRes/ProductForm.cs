using KURSACH_NOT_ANIMAL.Classes.DbClasses;
using KURSACH_NOT_ANIMAL.Classes.SystemClasses;
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

namespace KURSACH_NOT_ANIMAL.Forms.Admin.ProductRes
{
    public partial class ProductForm : Form
    {
        private bool? flagUpdate;
        private bool? flagInsert;
        private ProductView? product;
        private List<KURSACH_NOT_ANIMAL.Classes.DbClasses.Animal>? animals;
        private List<CategoryProduct>? categories;
        private List<int> animalsId = new List<int>();
        public ProductForm(bool? flagUpdate = null, bool? flagInsert = null, ProductView? product = null)
        {
            this.flagInsert = flagInsert;
            this.flagUpdate = flagUpdate;
            this.product = product;

            InitializeComponent();

            CMB_ANIMALS.DisplayMember = "Name";
            CMB_ANIMALS.ValueMember = "Id";

            CMB_CATEGORY.DisplayMember = "Name";
            CMB_CATEGORY.ValueMember = "Id";
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ComboBoxLoad();

            if (flagInsert == true)
                BTN_ACTION.Text = "Добавить";

            animalsId.Clear();
            TB_ANIMALS.Text = "";

            if (flagUpdate == true && product != null)
            {
                BTN_ACTION.Text = "Изменить";

                TB_NAME.Text = product.Name;
                TB_DESCRIPTION.Text = product.Description;
                TB_PRICE.Text = product.Price.ToString();
                TB_WEIGHT.Text = product.Weight.ToString();

                CMB_CATEGORY.SelectedValue = product.CategoryId;
                animalsId = ProductFromDb.GetRecomendationFromProduct(product.Id)?? new List<int>();

                string animalNames = "";
                if (animals != null)
                {
                    for (int i = 0; i < animalsId.Count; i++)
                    {
                        var name = animals.FirstOrDefault(a => a.Id == animalsId[i])?.Name;
                        if (!string.IsNullOrEmpty(name))
                        {
                            animalNames += string.IsNullOrEmpty(animalNames) ? "" : ", ";
                            animalNames += name;
                        }
                    }
                }

                TB_ANIMALS.Text = animalNames;
            }
        }

        private void BTN_ACTION_Click(object sender, EventArgs e)
        {
            if (TB_NAME.Text is null || string.IsNullOrWhiteSpace(TB_NAME.Text.Trim()))
            {
                MessageBox.Show("Необходимо заполнить наименование продукции.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int price;
            if (!int.TryParse(TB_PRICE.Text, out price) || price <= 0)
            {
                MessageBox.Show("Цена на проукцию должна быть целочисленной и больше 0.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double weight;
            if (!double.TryParse(TB_WEIGHT.Text, out weight) || weight <= 0)
            {
                MessageBox.Show("Вес продукции должен быть больше 0.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int categoryId;
            if (CMB_CATEGORY.SelectedValue is null || !int.TryParse(CMB_CATEGORY.SelectedValue.ToString(), out categoryId) || categoryId <= 0)
            {
                MessageBox.Show("Необходимо выбрать категорию товара.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = false;

            if (flagInsert == true)
            {
                result = ProductFromDb.AddProduct(Convert.ToDouble(TB_WEIGHT.Text), TB_NAME.Text, Convert.ToInt32(TB_PRICE.Text), Convert.ToInt32(CMB_CATEGORY.SelectedValue), TB_DESCRIPTION.Text, "");

                if (result)
                    if (!string.IsNullOrWhiteSpace(TB_ANIMALS.Text) && animalsId.Count > 0)
                    {
                        int? newProductId = ProductFromDb.GetMaxProductId();

                        if (newProductId is null)
                        {
                            MessageBox.Show("Не удалось добавить рекомендации,\n" +
                                "обратитесь к администратору системы.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return;
                        }

                        result = ProductFromDb.AddRecomendationsFromProduct(animalsId, MainForm.CurrentUser.Id, (int)newProductId);
                    }

                if (result)
                    MessageBox.Show("Продукция успешно добавлена.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (flagUpdate == true && product != null)
            {
                result = ProductFromDb.UpdateProduct(new Product(product.Id, Convert.ToDouble(TB_WEIGHT.Text),
                    TB_NAME.Text, "", TB_DESCRIPTION.Text, Convert.ToInt32(CMB_CATEGORY.SelectedValue.ToString()), 
                    Convert.ToInt32(TB_PRICE.Text)));

                if (result)
                    if (!string.IsNullOrWhiteSpace(TB_ANIMALS.Text) && animalsId.Count > 0)
                    {
                        result = ProductFromDb.DeleteRecomendationsForProduct(product.Id);

                        if (result)
                            result = ProductFromDb.AddRecomendationsFromProduct(animalsId, MainForm.CurrentUser.Id, product.Id);
                    }
                    else
                    {
                        result = ProductFromDb.DeleteRecomendationsForProduct(product.Id);
                    }

                if (result)
                    {
                        Logger.Log($"Была изменена продукция - Наименование до '{product.Name}'" +
                            $" после '{TB_NAME.Text}', пользователем {MainForm.CurrentUser.PHYO}");

                        MessageBox.Show("Продукция была успешно изменена.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }

            this.Close();
        }

        private void BTN_CLEAR_ANIMALS_Click(object sender, EventArgs e)
        {
            TB_ANIMALS.Text = "";
            animalsId.Clear();
        }

        private void CMB_ANIMALS_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedValue;
            if (CMB_ANIMALS.SelectedValue is null || !int.TryParse(CMB_ANIMALS.SelectedValue.ToString(), out selectedValue) || selectedValue <= 0)
                return;

            if (animals is null || animalsId.Contains(Convert.ToInt32(CMB_ANIMALS.SelectedValue)))
                return;

            animalsId.Add(Convert.ToInt32(CMB_ANIMALS.SelectedValue));

            if (animals is null)
                animals = new List<KURSACH_NOT_ANIMAL.Classes.DbClasses.Animal>();

            int selectedId = Convert.ToInt32(CMB_ANIMALS.SelectedValue);
            string selectedAnimalName = animals.FirstOrDefault(a => a.Id == selectedId)?.Name ?? "";

            if (!string.IsNullOrEmpty(selectedAnimalName))
                TB_ANIMALS.Text += (string.IsNullOrEmpty(TB_ANIMALS.Text) ? "" : ", ") + selectedAnimalName;
        }

        private void ComboBoxLoad()
        {
            animals = AnimalFromDb.GetAllAnimals();
            CMB_ANIMALS.DataSource = animals;

            categories = ProductFromDb.GetAllCategories();
            CMB_CATEGORY.DataSource = categories;
        }
    }
}
