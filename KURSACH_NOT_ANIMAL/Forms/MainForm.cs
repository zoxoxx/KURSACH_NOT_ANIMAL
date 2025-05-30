﻿using KURSACH_NOT_ANIMAL.Classes.DbClasses;
using KURSACH_NOT_ANIMAL.Classes.ViewClasses;
using KURSACH_NOT_ANIMAL.Forms.Admin;
using KURSACH_NOT_ANIMAL.Forms.Admin.Operations;
using KURSACH_NOT_ANIMAL.Forms.Admin.ProductRes;
using KURSACH_NOT_ANIMAL.Forms.Admin.ScheduleRes;
using KURSACH_NOT_ANIMAL.Forms.Admin.Shop;
using KURSACH_NOT_ANIMAL.Forms.Admin.Sklad;
using KURSACH_NOT_ANIMAL.Forms.Client.OperationRes;
using KURSACH_NOT_ANIMAL.Forms.Reestr;
using KURSACH_NOT_ANIMAL.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSACH_NOT_ANIMAL.Forms
{
    public partial class MainForm : Form
    {
        public static UserSystem CurrentUser { get; set; } = default!;
        List<ProductView>? products;
        List<ProductView>? recomendations;
        List<ProductView>? productsFilter;

        public MainForm(UserSystem currentUser)
        {
            CurrentUser = currentUser;

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!UserFromDb.CheckRoleAcess(CurrentUser.Id, "Администратор"))
                MENU_ADMIN.Visible = false;

            if (!UserFromDb.CheckRoleAcess(CurrentUser.Id, "Продавец"))
                MENU_WORK.Visible = false;

            DataGridLoad();
        }

        private void MENU_PROFILE_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(CurrentUser);
            profileForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => Program.StartForm.Show();

        private void MENU_ITEM_ANIMALS_Click(object sender, EventArgs e)
        {
            AnimalReestr animalReestr = new AnimalReestr();
            animalReestr.ShowDialog();
        }

        private void MENU_ITEM_USERS_Click(object sender, EventArgs e)
        {
            UserReestr userReestr = new UserReestr();
            userReestr.ShowDialog();
        }

        private void MENU_ITEM_PARTNERS_Click(object sender, EventArgs e)
        {
            ShopReestr shopReestr = new ShopReestr(flagPartner: true);
            this.Hide();
            shopReestr.ShowDialog();
            this.Show();
        }

        private void MENU_ITEM_SKLAD_Click(object sender, EventArgs e)
        {
            SkladReestr skladReestr = new SkladReestr();
            this.Hide();
            skladReestr.ShowDialog();
            this.Show();
        }

        private void MENU_ITEM_SCHEDULE_Click(object sender, EventArgs e)
        {
            ScheduleReestr scheduleReestr = new ScheduleReestr();
            this.Hide();
            scheduleReestr.ShowDialog();
            this.Show();
        }

        private void MENU_ITEM_OPERATIONS_Click(object sender, EventArgs e)
        {
            OperationsReestr operationsReestr = new OperationsReestr();
            this.Hide();
            operationsReestr.ShowDialog();
            this.Show();
        }

        private void MENU_ITEM_PRODUCTS_Click(object sender, EventArgs e)
        {
            ProductReestr productReestr = new ProductReestr();
            this.Hide();
            productReestr.ShowDialog();
            this.Show();

            DataGridLoad();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (UserFromDb.CheckRoleAcess(CurrentUser.Id, "Продавец"))
            {
                if (!ScheduleFromDb.CheckWorktime(CurrentUser.Id))
                    MessageBox.Show("Сейчас нерабочее время. Оно будет засчитано как переработка", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DataGridLoad()
        {
            products = ProductFromDb.GetProductsWithCategory();
            this.DG_PRODUCTS.DataSource = products;
        }

        private void TB_SEARCH_TextChanged(object sender, EventArgs e)
        {
            if (products is null)
                return;

            if (TB_SEARCH.Text.Trim() == "")
            {
                DataGridLoad();
                return;
            }

            productsFilter = products;

            string filter = TB_SEARCH.Text;
            recomendations = ProductFromDb.GetProductsWithMaskRecomendation(filter);

            if (recomendations is null)
            {
                productsFilter = products.Where(p => p.Name.Contains(filter)).ToList();
                this.DG_PRODUCTS.DataSource = productsFilter;
            }
            else
            {
                HashSet<int> recomendationIds = new HashSet<int>(recomendations.Select(r => r.Id));
                productsFilter = products
                    .Where(p =>
                        p.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0
                        || recomendationIds.Contains(p.Id))
                    .ToList();
            }
            this.DG_PRODUCTS.DataSource = productsFilter;
        }

        private void DG_PRODUCTS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!UserFromDb.CheckRoleAcess(CurrentUser.Id, "Клиент"))
                return;

            ProductView? selectedProduct = this.DG_PRODUCTS.CurrentRow.DataBoundItem as ProductView;

            if (selectedProduct is null)
                return;

            OperationForm operationForm = new OperationForm(selectedProduct);
            this.Hide();
            operationForm.ShowDialog();
            this.Show();

            DataGridLoad();
        }
    }
}
