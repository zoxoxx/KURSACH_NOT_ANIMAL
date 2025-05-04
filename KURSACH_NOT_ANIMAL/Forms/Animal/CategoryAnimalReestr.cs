using KURSACH_NOT_ANIMAL.Classes.DbClasses;
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

namespace KURSACH_NOT_ANIMAL.Forms.Animal
{
    public partial class CategoryAnimalReestr : Form
    {
        List<CategoryAnimal>? categories;
        bool? flagDelete;
        bool? flagUpdate;
        public CategoryAnimalReestr(bool? flagDelete = null, bool? flagUpdate = null)
        {
            this.flagDelete = flagDelete;
            this.flagUpdate = flagUpdate;

            InitializeComponent();

            DG_CATEGORIES.Columns[0].DataPropertyName = "Id";
            DG_CATEGORIES.Columns[1].DataPropertyName = "Name";
            DG_CATEGORIES.Columns[2].DataPropertyName = "Desciption";
        }

        private void CategoryAnimalReestr_Load(object sender, EventArgs e)
        {
            DataGridLoad();
        }

        private void DataGridLoad()
        {
            categories = AnimalFromDb.GetAllCategorys();
            DG_CATEGORIES.DataSource = categories;
        }

        private void DG_CATEGORIES_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            CategoryAnimal? selectedCategory = DG_CATEGORIES.Rows[e.RowIndex].DataBoundItem as CategoryAnimal;

            if (selectedCategory is null)
                return;

            Form? categoryAnimalForm = null;

            if (flagDelete != null)
                categoryAnimalForm = new CategoryAnimalForm(categoryId: selectedCategory.Id, flagDelete: true);

            if (flagUpdate != null)
                categoryAnimalForm = new CategoryAnimalForm(categoryId: selectedCategory.Id, flagUpdate: true);

            if (categoryAnimalForm != null)
                categoryAnimalForm.ShowDialog();

            DataGridLoad();
        }
    }
}
