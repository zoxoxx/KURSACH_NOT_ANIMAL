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
    public partial class ShopReestr : Form
    {
        bool? flagPartner;
        List<ShopView>? shops;
        public ShopReestr(bool? flagPartner = null)
        {
            this.flagPartner = flagPartner;

            InitializeComponent();

            DG_SHOPS.Columns[0].DataPropertyName = "Id";
            DG_SHOPS.Columns[1].DataPropertyName = "Name";
            DG_SHOPS.Columns[2].DataPropertyName = "Adress";
            DG_SHOPS.Columns[3].DataPropertyName = "CityId";
            DG_SHOPS.Columns[4].DataPropertyName = "CityName";

            DG_SHOPS.AutoGenerateColumns = false;
        }

        private void ShopReestr_Load(object sender, EventArgs e)
        {
            if (flagPartner == true)
                this.Text += "Магазины партнеров";

            if (flagShop == true)
                this.Text = "Наши магазины";

            DataGridLoad();
        }



        private void DataGridLoad()
        {
            if (flagPartner == true)
                shops = ShopFromDb.GetPartnerShops();

            DG_SHOPS.DataSource = shops;
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            Form? shopForm;
            shopForm = new ShopForm(flagInsert: true, flagPartner: true);

            this.Hide();
            shopForm.ShowDialog();
            this.Show();

            DataGridLoad();
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            ShopView? selectedShop = DG_SHOPS.CurrentRow.DataBoundItem as ShopView;

            if (selectedShop is null)
                return;

            if (flagPartner == true)
                ShopFromDb.DeletePartnerShop(selectedShop.Id);

            DataGridLoad();
        }

        private void DG_SHOPS_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShopView? selectedShop = DG_SHOPS.CurrentRow.DataBoundItem as ShopView;

            if (selectedShop is null)
                return;

            Form? shopForm;
            shopForm = new ShopForm(flagUpdate: true, flagPartner: true, shop: selectedShop);


            this.Hide();
            shopForm.ShowDialog();
            this.Show();

            DataGridLoad();
        }
    }
}
