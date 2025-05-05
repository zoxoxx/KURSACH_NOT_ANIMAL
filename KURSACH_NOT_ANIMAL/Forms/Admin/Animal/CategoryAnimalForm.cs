using KURSACH_NOT_ANIMAL.Classes.DbClasses;
using KURSACH_NOT_ANIMAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSACH_NOT_ANIMAL.Forms.Animal
{
    public partial class CategoryAnimalForm : Form
    {
        string? categoryName;
        bool? flagDelete;
        bool? flagInsert;
        bool? flagUpdate;
        CategoryAnimal? categoryAnimal;
        public CategoryAnimalForm(string? categoryName = null, bool? flagDelete = null, bool? flagInsert = null, bool? flagUpdate = null)
        {
            if (categoryName != null)
                categoryAnimal = AnimalFromDb.GetCategory(categoryName);

            this.categoryName = categoryName;
            this.flagDelete = flagDelete;
            this.flagInsert = flagInsert;
            this.flagUpdate = flagUpdate;

            InitializeComponent();
        }

        private void BTN_ACTION_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TB_NAME.Text))
            {
                MessageBox.Show("Наименование не может быть пустым.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (categoryAnimal is null)
                categoryAnimal = new CategoryAnimal();

            categoryAnimal.Name = TB_NAME.Text;
            categoryAnimal.Description = string.IsNullOrWhiteSpace(TB_DESCIPRION.Text) ? "" : TB_DESCIPRION.Text;

            if (flagDelete != null)
            { 
                AnimalFromDb.DeleteCategory(categoryAnimal.Id);
                MessageBox.Show("Категория успешно удалена.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (flagInsert != null)
            { 
                AnimalFromDb.AddCategory(TB_NAME.Text, TB_DESCIPRION.Text);
                MessageBox.Show("Категория успешно добавлена.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (flagUpdate != null)
            {
                AnimalFromDb.UpdateCategory(categoryAnimal);
                MessageBox.Show("Категория успешно обновлена.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }

        private void CategoryAnimalForm_Load(object sender, EventArgs e)
        {
            if (flagDelete != null)
            {
                BTN_ACTION.Text = "Удалить";
                TB_DESCIPRION.Enabled = false;
                TB_NAME.Enabled = false;
            }

            if (flagInsert != null)
                BTN_ACTION.Text = "Добавить";

            if (flagUpdate != null)
                BTN_ACTION.Text = "Изменить";

            if (categoryAnimal != null)
            { 
                TB_NAME.Text = categoryAnimal.Name;
                TB_DESCIPRION.Text = categoryAnimal.Description ?? "";
            }
        }
    }
}
