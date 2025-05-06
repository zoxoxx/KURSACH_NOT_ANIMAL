using KURSACH_NOT_ANIMAL.Classes.DbClasses;
using KURSACH_NOT_ANIMAL.Classes.SystemClasses;
using KURSACH_NOT_ANIMAL.Classes.ViewClasses;
using KURSACH_NOT_ANIMAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSACH_NOT_ANIMAL.Forms.Admin.Sklad
{
    public partial class SkladForm : Form
    {
        private SkladView? purchase;
        private bool? flagInsert;
        private bool? flagUpdate;
        private List<ShopView>? shops;
        private List<ShopView>? partners;
        private List<Product>? products;

        public SkladForm(bool? flagInsert = null, bool? flagUpdate = null, SkladView? purchase = null)
        {
            this.flagInsert = flagInsert;
            this.flagUpdate = flagUpdate;
            this.purchase = purchase;

            InitializeComponent();

            CMB_PARTNER.DisplayMember = "Name";
            CMB_PARTNER.ValueMember = "Id";

            CMB_SHOP.DisplayMember = "Name";
            CMB_SHOP.ValueMember = "Id";

            CMB_PRODUCT.DisplayMember = "Name";
            CMB_PRODUCT.ValueMember = "Id";
        }

        private void BTN_ACTION_Click(object sender, EventArgs e)
        {
            int count;
            if (!int.TryParse(TB_COUNT.Text, out count) || count <= 0)
            {
                MessageBox.Show("Количество поставленного товара должно быть целочисленным и больше 0.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double price;
            if (!double.TryParse(TB_PRICE.Text, out price) || price <= 0)
            {
                MessageBox.Show("Цена закупки должна быть целочисленная и больше 0.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CMB_SHOP.SelectedValue is null || Convert.ToInt32(CMB_SHOP.SelectedValue) <= 0)
            {
                MessageBox.Show("Выберите магазин, если отсутствует необходимый магазин, обратитесь к администратору системы.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CMB_PARTNER.SelectedValue is null || Convert.ToInt32(CMB_PARTNER.SelectedValue) <= 0)
            {
                MessageBox.Show("Выберите партнера, если отсутствует необходимый партнер, обратитесь к администратору системы.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CMB_PRODUCT.SelectedValue is null || Convert.ToInt32(CMB_PRODUCT.SelectedValue) <= 0)
            {
                MessageBox.Show("Выберите продукцию, если отсутствует необходимая продукция, обратитесь к администратору системы.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (flagInsert == true)
            {
                string dateString = LBL_DATE.Text;
                DateTime parsedDate;
                DateOnly datePurchase = DateOnly.FromDateTime(DateTime.Now);

                if (DateTime.TryParse(dateString, out parsedDate))
                    datePurchase = DateOnly.FromDateTime(parsedDate);

                bool result = SkladFromDb.AddPurchase(Convert.ToInt32(CMB_PRODUCT.SelectedValue), Convert.ToInt32(TB_COUNT.Text), 
                    Convert.ToInt32(CMB_SHOP.SelectedValue), Convert.ToInt32(CMB_PARTNER.SelectedValue), 
                    Convert.ToDouble(TB_PRICE.Text), datePurchase);

                if (result)
                    MessageBox.Show("Закупка успешно заполнена.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (flagUpdate == true && purchase != null)
            {
                string dateString = LBL_DATE.Text;
                DateTime parsedDate;
                DateOnly datePurchase = DateOnly.FromDateTime(DateTime.Now);

                if (DateTime.TryParse(dateString, out parsedDate))
                    datePurchase = DateOnly.FromDateTime(parsedDate);

                bool result = SkladFromDb.UpdatePurchase(Convert.ToInt32(CMB_PRODUCT.SelectedValue), Convert.ToInt32(TB_COUNT.Text), 
                    Convert.ToInt32(CMB_SHOP.SelectedValue), Convert.ToInt32(CMB_PARTNER.SelectedValue), 
                    Convert.ToDouble(TB_PRICE.Text), datePurchase, purchase.Id);

                if (result)
                    Logger.Log($"Была обновлена закупка продукции '{purchase.ProductName}' в количестве {purchase.Count}, пользователем {MainForm.CurrentUser.PHYO}.");
            }

            this.Close();
        }

        private void SkladForm_Load(object sender, EventArgs e)
        {
            ComboBoxLoad();

            if (flagInsert == true)
            {
                LBL_DATE.Text = DateOnly.FromDateTime(DateTime.Now).ToString();
                BTN_ACTION.Text = "Добавить";
                return;
            }

            if (flagUpdate == true && purchase != null)
            {
                BTN_ACTION.Text = "Изменить";
                TB_COUNT.Text = purchase.Count.ToString();
                TB_PRICE.Text = purchase.PurchasePrice.ToString();
                LBL_DATE.Text = purchase.DatePrihod.ToString();

                KURSACH_NOT_ANIMAL.Classes.DbClasses.Sklad? dbPurchase = SkladFromDb.GetDbPurchase(purchase.Id);

                if (dbPurchase is null)
                {
                    MessageBox.Show("Во воремя работы с закупкой она была удалена другим пользователем.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                CMB_PARTNER.SelectedValue = dbPurchase.PartnerId;
                CMB_SHOP.SelectedValue = dbPurchase.ShopId;
                CMB_PRODUCT.SelectedValue = dbPurchase.ProductId;
            }
        }

        private void ComboBoxLoad()
        {
            partners = ShopFromDb.GetPartnerShops();
            CMB_PARTNER.DataSource = partners;

            shops = ShopFromDb.GetOurShops();
            CMB_SHOP.DataSource = shops;

            products = ProductFromDb.GetProducts();
            CMB_PRODUCT.DataSource = products;
        }
    }
}
