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

namespace KURSACH_NOT_ANIMAL.Forms.Admin.ScheduleRes
{
    public partial class ScheduleForm : Form
    {
        private List<UserView>? users;
        private ScheduleView _scheduleRow;
        public ScheduleView ScheduleRow
        {
            get { return _scheduleRow; }
            set
            {
                _scheduleRow = value;
                CB_USER.SelectedValue = ScheduleRow.UserId;
                DTP_DATE.Value = ScheduleRow.DateJob.ToDateTime(TimeOnly.MinValue);
                DTP_START.Value = DateTime.Today.Add(ScheduleRow.TimeStart.ToTimeSpan());
                DTP_END.Value = DateTime.Today.Add(ScheduleRow.TimeEnd.ToTimeSpan());
            }
        }
        public ScheduleForm()
        {
            InitializeComponent();

            CB_USER.DisplayMember = "Phyo";
            CB_USER.ValueMember = "Id";
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            users = UserFromDb.GetWorkers();
            CB_USER.DataSource = users;
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            if (CB_USER.SelectedValue == null || !int.TryParse(CB_USER.SelectedValue.ToString(), out int uid) || uid <= 0)
            {
                MessageBox.Show("Не выбрано ФИО работника", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DTP_END.Value.TimeOfDay <= DTP_START.Value.TimeOfDay)
            {
                MessageBox.Show("Время окончания должно быть позже времени начала", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var selectedUser = CB_USER.SelectedItem as UserView;
                if (selectedUser == null)
                {
                    MessageBox.Show("Ошибка при получении данных пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ScheduleRow.UserId = uid;
                ScheduleRow.PHYO = selectedUser.Phyo;
                ScheduleRow.DateJob = DateOnly.FromDateTime(DTP_DATE.Value);
                ScheduleRow.TimeStart = TimeOnly.FromDateTime(DTP_START.Value);
                ScheduleRow.TimeEnd = TimeOnly.FromDateTime(DTP_END.Value);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
