using KURSACH_NOT_ANIMAL.Classes.DbClasses;
using KURSACH_NOT_ANIMAL.Classes.ViewClasses;
using KURSACH_NOT_ANIMAL.Forms.Animal;
using KURSACH_NOT_ANIMAL.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSACH_NOT_ANIMAL.Forms.Reestr
{
    public partial class AnimalReestr : Form
    {
        List<AnimalView>? animals;
        List<CategoryAnimal>? categories = new List<CategoryAnimal>();
        private int editableRowIndex = -1;
        public AnimalReestr()
        {
            InitializeComponent();

            DG_ANIMALS.Columns[0].DataPropertyName = "AnimalId";
            DG_ANIMALS.Columns[1].DataPropertyName = "Name";
            DG_ANIMALS.Columns[2].DataPropertyName = "Description";
            DG_ANIMALS.Columns[3].DataPropertyName = "CategoryName";
            DG_ANIMALS.Columns[4].DataPropertyName = "CategoryDescription";
            DG_ANIMALS.Columns[5].DataPropertyName = "CategoryId";

            DG_ANIMALS.AllowUserToAddRows = false;
            DG_ANIMALS.EditMode = DataGridViewEditMode.EditOnEnter;
            DG_ANIMALS.AutoGenerateColumns = false;
        }

        private void AnimalReestr_Load(object sender, EventArgs e)
        {
            LoadCategories();
            DataGridLoad();
        }

        private void DataGridLoad()
        {
            animals = AnimalFromDb.GetAnimalWithCategory();
            DG_ANIMALS.DataSource = animals;
        }

        private void LoadCategories()
        {
            var columnCategory = (DataGridViewComboBoxColumn)DG_ANIMALS.Columns["CategoryName"];
            categories = AnimalFromDb.GetAllCategorys();

            if (categories is null)
                categories = new List<CategoryAnimal>();

            categories.Add(new CategoryAnimal(-1, "Удалить"));
            categories.Add(new CategoryAnimal(-2, "Изменить"));
            categories.Add(new CategoryAnimal(-3, "Добавить"));

            categories = categories.OrderBy(c => c.Id).ToList();

            columnCategory.DataSource = categories;
            columnCategory.DisplayMember = "Name";
            columnCategory.ValueMember = "Name";
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            DataGridViewRow? emptyRow = null;
            foreach (DataGridViewRow row in DG_ANIMALS.Rows)
            {
                object cellVal = row.Cells[0].Value;
                if ((cellVal == null || string.IsNullOrWhiteSpace(cellVal.ToString()))
                    && row.Visible && DG_ANIMALS.Columns[1].Visible)
                {
                    emptyRow = row;
                    break;
                }
            }

            if (emptyRow != null)
            {
                DG_ANIMALS.CurrentCell = emptyRow.Cells[1];
                DG_ANIMALS.BeginEdit(true);
            }
            else
            {
                if (animals is null)
                    animals = new List<AnimalView>();

                animals.Add(new AnimalView(0));
                DG_ANIMALS.DataSource = null;
                DG_ANIMALS.DataSource = animals;

                int rowIndex = DG_ANIMALS.Rows.Count - 1; 
                if (DG_ANIMALS.Rows[rowIndex].Visible && DG_ANIMALS.Columns[1].Visible)
                {
                    DG_ANIMALS.CurrentCell = DG_ANIMALS.Rows[rowIndex].Cells[1];

                    DG_ANIMALS.BeginEdit(true);
                }
            }
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            if (DG_ANIMALS.Rows.Count == 0)
            {
                MessageBox.Show("Строки отсутствуют, сначала необходимо добавить строки.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DG_ANIMALS.CurrentRow is null)
            {
                MessageBox.Show("Выберите строку.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DG_ANIMALS.CurrentRow is null || DG_ANIMALS.CurrentRow.IsNewRow)
                return;

            editableRowIndex = DG_ANIMALS.CurrentRow.Index;
            DG_ANIMALS.CurrentCell = DG_ANIMALS.Rows[editableRowIndex].Cells[1];
            DG_ANIMALS.BeginEdit(true);
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            if (DG_ANIMALS.Rows.Count == 0)
            {
                MessageBox.Show("Строки отсутствуют, сначала необходимо добавить строки.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DG_ANIMALS.CurrentRow is null)
            {
                MessageBox.Show("Выберите строку.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AnimalView selectedAnimal = (DG_ANIMALS.CurrentRow.DataBoundItem as AnimalView)!;
            if (string.IsNullOrWhiteSpace(selectedAnimal.AnimalId.ToString()) || selectedAnimal.AnimalId == 0)
            {
                MessageBox.Show("Добавление животного не было завершено.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool resultDelete = AnimalFromDb.DeleteAnimal(selectedAnimal.AnimalId);

            if (resultDelete)
                MessageBox.Show($"Животное {selectedAnimal.Name} успешно удалено.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadCategories();
            DataGridLoad();
        }

        private void DG_ANIMALS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= DG_ANIMALS.Rows.Count)
                return;
            if (e.ColumnIndex < 0 || e.ColumnIndex >= DG_ANIMALS.Columns.Count)
                return;

            if (DG_ANIMALS.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            { 
                ComboBoxHandler(e);
                return;
            }

            if (DG_ANIMALS.Rows.Count <= 0)
                return;

            AnimalView? selectedAnimal = DG_ANIMALS.Rows[e.RowIndex].DataBoundItem as AnimalView;
            if (selectedAnimal is null)
                return;

            if (selectedAnimal.AnimalId == 0 && selectedAnimal.CategoryId != 0 &&
                selectedAnimal.CategoryId != null && !string.IsNullOrWhiteSpace(selectedAnimal.Name))
            {
                AnimalFromDb.AddAnimal(selectedAnimal.Name, (int)selectedAnimal.CategoryId, selectedAnimal.Description ?? "");

                if (animals is null)
                    animals = new List<AnimalView>();

                animals[e.RowIndex].AnimalId = AnimalFromDb.GetMaxAnimalId();
                DG_ANIMALS.DataSource = animals;
                return;
            }

            if (selectedAnimal.CategoryId != null && !string.IsNullOrWhiteSpace(selectedAnimal.Name) && selectedAnimal.AnimalId != 0 && selectedAnimal.CategoryId > 0)
                AnimalFromDb.UpdateAnimal(new Classes.DbClasses.Animal(selectedAnimal.AnimalId, selectedAnimal.Name, (int)selectedAnimal.CategoryId, selectedAnimal.Description?? ""));
        }

        private void ComboBoxHandler(DataGridViewCellEventArgs e)
        {
            string? selectedValue = DG_ANIMALS.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() ?? "";

            var comboColumn = DG_ANIMALS.Columns[e.ColumnIndex] as DataGridViewComboBoxColumn;
            if (comboColumn is null || comboColumn.DataSource is null)
                return;

            OpenAnimalCrudForm(selectedValue);
        }

        private void OpenAnimalCrudForm(string? selectedValue)
        {

            Form? categoryAnimalForm = null;

            if (selectedValue == "Добавить")
                categoryAnimalForm = new CategoryAnimalForm(flagInsert: true);

            if (selectedValue == "Удалить")
                categoryAnimalForm = new CategoryAnimalReestr(flagDelete: true);

            if (selectedValue == "Изменить")
                categoryAnimalForm = new CategoryAnimalReestr(flagUpdate: true);

            if (categoryAnimalForm != null)
            {
                categoryAnimalForm.ShowDialog();

                LoadCategories();
                DataGridLoad();
            }
            else
            {
                CategoryAnimal? selectedCategory = AnimalFromDb.GetCategory(selectedValue!);
                if (selectedCategory is null)
                    return;

                animals![DG_ANIMALS.CurrentRow.Index].CategoryId = selectedCategory.Id;
                animals![DG_ANIMALS.CurrentRow.Index].CategoryName = selectedCategory.Name;
                animals![DG_ANIMALS.CurrentRow.Index].CategoryDescription = selectedCategory.Description?? "";
                DG_ANIMALS.DataSource = animals;
                DG_ANIMALS.Refresh();
            }
        }

        private void DG_ANIMALS_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (DG_ANIMALS.Rows[e.RowIndex].DataBoundItem is null)
                return;

            AnimalView? selectedAnimal = DG_ANIMALS.Rows[e.RowIndex].DataBoundItem as AnimalView;

            if (selectedAnimal is null)
                return;

            if (string.IsNullOrWhiteSpace(selectedAnimal.AnimalId.ToString()) || selectedAnimal.AnimalId == 0)
                return;

            if (e.RowIndex != editableRowIndex)
                e.Cancel = true;
        }
    }
}
