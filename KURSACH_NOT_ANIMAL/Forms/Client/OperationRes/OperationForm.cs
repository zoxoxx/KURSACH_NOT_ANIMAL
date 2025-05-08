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

namespace KURSACH_NOT_ANIMAL.Forms.Client.OperationRes
{
    public partial class OperationForm : Form
    {
        ProductView product;
        int lastCount = 0;
        public OperationForm(ProductView product)
        {
            this.product = product;

            InitializeComponent();
        }

        private void BTN_CREATE_OPERATION_Click(object sender, EventArgs e)
        {
            int count;
            if (TB_COUNT.Text is null || !int.TryParse(TB_COUNT.Text, out count) || count <= 0)
            {
                MessageBox.Show("Количество товара в заявке должно быть больше 0.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int finalPrice;
            if (TB_FINAL_PRICE.Text is null || !int.TryParse(TB_FINAL_PRICE.Text, out finalPrice) || finalPrice <= 0)
            {
                MessageBox.Show("Итоговая цена должна быть больше 0.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = OperationFromDb.AddOperation(Convert.ToInt32(TB_FINAL_PRICE.Text), MainForm.CurrentUser.Id, product.Id, Convert.ToInt32(TB_COUNT.Text));

            if (result)
                MessageBox.Show("Заявка успешно оставлена.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void OperationForm_Load(object sender, EventArgs e)
        {
            LBL_PRICE.Text = product.Price.ToString();
            LBL_WEIGHT.Text = product.Weight.ToString();
            LBL_NAME.Text = product.Name;
            TB_DESCRIPTION.Text = product.Description?? "";
        }

        private void TB_COUNT_TextChanged(object sender, EventArgs e)
        {
            int count;
            if (!int.TryParse(TB_COUNT.Text, out count))
                TB_COUNT.Text = lastCount.ToString();

            TB_FINAL_PRICE.Text = (Convert.ToInt32(TB_COUNT.Text) * product.Price).ToString();
        }

        private void TB_COUNT_Enter(object sender, EventArgs e)
        {
            int count;
            if (int.TryParse(TB_COUNT.Text, out count))
                lastCount = Convert.ToInt32(TB_COUNT.Text);
        }
    }
}
