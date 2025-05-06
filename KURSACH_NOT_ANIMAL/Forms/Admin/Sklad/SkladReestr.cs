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

namespace KURSACH_NOT_ANIMAL.Forms.Admin.Sklad
{
    public partial class SkladReestr : Form
    {
        private List<SkladView>? purchases;
        public SkladReestr()
        {
            InitializeComponent();

            DG_SKLAD.Columns[0].DataPropertyName = "Id";
            DG_SKLAD.Columns[1].DataPropertyName = "ProductName";
            DG_SKLAD.Columns[2].DataPropertyName = "Count";
            DG_SKLAD.Columns[3].DataPropertyName = "ShopName";
            DG_SKLAD.Columns[4].DataPropertyName = "PartnerName";
            DG_SKLAD.Columns[5].DataPropertyName = "PurchasePrice";
            DG_SKLAD.Columns[6].DataPropertyName = "DatePrihod";

            DG_SKLAD.AutoGenerateColumns = false;
        }

        private void SkladReestr_Load(object sender, EventArgs e)
        {
            DataGridLoad();
        }

        private void DataGridLoad()
        {
            purchases = SkladFromDb.GetAllPurchases();
            DG_SKLAD.DataSource = purchases;
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            SkladForm skladForm = new SkladForm(flagInsert: true);
            this.Hide();
            skladForm.ShowDialog();
            this.Show();

            DataGridLoad();
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            SkladView? selectedPurchase = DG_SKLAD.CurrentRow.DataBoundItem as SkladView;

            if (selectedPurchase is null)
                return;

            bool result = SkladFromDb.DeletePurchase(selectedPurchase.Id);

            if (result)
            {
                Logger.Log($"Была удалена закупка продукции '{selectedPurchase.ProductName}' на количество {selectedPurchase.Count}, пользователем {MainForm.CurrentUser.PHYO}.");
                DataGridLoad();
            }
        }

        private void DG_SKLAD_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SkladView? selectedPurchase = DG_SKLAD.CurrentRow.DataBoundItem as SkladView;

            if (selectedPurchase is null)
                return;

            SkladForm skladForm = new SkladForm(flagUpdate: true, purchase: selectedPurchase);
            this.Hide();
            skladForm.ShowDialog();
            this.Show();

            DataGridLoad();
        }
    }
}
