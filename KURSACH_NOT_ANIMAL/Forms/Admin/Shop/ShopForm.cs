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

namespace KURSACH_NOT_ANIMAL.Forms.Admin.Shop
{
    public partial class ShopForm : Form
    {
        private bool? flagShop;
        private bool? flagPartner;
        private bool? flagInsert;
        private bool? flagUpdate;
        private ShopView? shop;
        private List<City>? cities; 
        public ShopForm(bool? flagShop = null, bool? flagPartner = null,
            bool? flagInsert = null, bool? flagUpdate = null, ShopView? shop = null)
        {
            this.flagShop = flagShop;
            this.flagPartner = flagPartner;
            this.flagInsert = flagInsert;
            this.flagUpdate = flagUpdate;
            this.shop = shop;

            InitializeComponent();

            CMB_CITY.DisplayMember = "Name";
            CMB_CITY.ValueMember = "Id";
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            ComboBoxLoad();

            if (flagInsert == true)
                BTN_ACTION.Text = "Добавить";

            if (flagUpdate == true && shop != null)
            { 
                BTN_ACTION.Text = "Изменить";
                TB_ADRESS.Text = shop.Adress;
                TB_NAME.Text = shop.Name;
                CMB_CITY.SelectedValue = shop.CityId;
            }


        }

        private void ComboBoxLoad()
        {
            cities = ShopFromDb.GetCities();
            CMB_CITY.DataSource = cities;
        }

        private void BTN_ACTION_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TB_ADRESS.Text))
            {
                MessageBox.Show("Адрес магазина должен быть заполнен.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TB_NAME.Text))
            {
                MessageBox.Show("Имя магазина должно быть заполнено.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CMB_CITY.SelectedValue is null)
            {
                MessageBox.Show("Необходимо выбрать город для магазина\n" +
                    "если список городов отсутствует или нет необходимого города," +
                    "\nобратитесь к администратору системы.", "Внимание", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (flagInsert == true)
            {
                bool result = false;
                if (flagShop == true)
                    result = ShopFromDb.AddShop(TB_NAME.Text, TB_ADRESS.Text, Convert.ToInt32(CMB_CITY.SelectedValue));

                if (flagPartner == true)
                    result = ShopFromDb.AddPartnerShop(TB_NAME.Text, TB_ADRESS.Text, Convert.ToInt32(CMB_CITY.SelectedValue));

                if (result)
                    MessageBox.Show("Магазин успешно добавлен.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (flagUpdate == true && shop != null)
            {
                bool result = false;
                if (flagShop == true)
                    result = ShopFromDb.UpdateShop(shop.Id, TB_NAME.Text, TB_ADRESS.Text, Convert.ToInt32(CMB_CITY.SelectedValue));

                if (flagPartner == true)
                    result = ShopFromDb.UpdatePartnerShop(shop.Id, TB_NAME.Text, TB_ADRESS.Text, Convert.ToInt32(CMB_CITY.SelectedValue));

                if (result)
                    MessageBox.Show("Магазин успешно обновлен.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }
    }
}
