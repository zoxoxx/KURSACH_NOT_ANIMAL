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
        bool? flagShop;
        bool? flagPartner;
        List<ShopView>? shops;
        public ShopReestr(bool? flagShop = null, bool? flagPartner = null)
        {
            this.flagPartner = flagPartner;
            this.flagShop = flagShop;

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
            DataGridLoad();
        }



        private void DataGridLoad()
        {
            if (flagPartner == true)
                shops = ShopFromDb.GetPartnerShops();

            if (flagShop == true)
                shops = ShopFromDb.GetOurShops();

            DG_SHOPS.DataSource = shops;
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            Form? shopForm;

            if (flagPartner == true)
            {
                shopForm = new ShopForm(flagInsert: true, flagPartner: true);
            }
            else
            {
                shopForm = new ShopForm(flagInsert: true, flagShop: true);
            }

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

            if (flagShop == true)
                ShopFromDb.DeleteShop(selectedShop.Id);

            DataGridLoad();
        }

        private void DG_SHOPS_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShopView? selectedShop = DG_SHOPS.CurrentRow.DataBoundItem as ShopView;

            if (selectedShop is null)
                return;

            Form? shopForm;

            if (flagPartner == true)
            {
                shopForm = new ShopForm(flagUpdate: true, flagPartner: true, shop: selectedShop);
            }
            else
            {
                shopForm = new ShopForm(flagUpdate: true, flagShop: true, shop: selectedShop);
            }

            this.Hide();
            shopForm.ShowDialog();
            this.Show();

            DataGridLoad();
        }
    }
}
