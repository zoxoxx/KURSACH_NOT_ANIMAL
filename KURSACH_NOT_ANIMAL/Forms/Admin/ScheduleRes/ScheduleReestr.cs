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
    public partial class ScheduleReestr : Form
    {
        List<ScheduleView> schedule = new List<ScheduleView>();
        private readonly ScheduleForm scheduleForm = new ScheduleForm();
        public ScheduleReestr()
        {
            InitializeComponent();

            DG_SCHEDULE.Columns[0].DataPropertyName = "Id";
            DG_SCHEDULE.Columns[1].DataPropertyName = "UserId";
            DG_SCHEDULE.Columns[2].DataPropertyName = "PHYO";
            DG_SCHEDULE.Columns[3].DataPropertyName = "DateJob";
            DG_SCHEDULE.Columns[4].DataPropertyName = "TimeStart";
            DG_SCHEDULE.Columns[5].DataPropertyName = "TimeEnd";

            DG_SCHEDULE.AllowUserToAddRows = false;
            DG_SCHEDULE.AutoGenerateColumns = false;
        }

        private void ScheduleReestr_Load(object sender, EventArgs e)
        {
            DataGridLoad();
        }
        private void DataGridLoad()
        {
            schedule = ScheduleFromDb.GetScheduleView();
            DG_SCHEDULE.DataSource = schedule;
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            var scheduleRow = new ScheduleView();
            scheduleForm.ScheduleRow = scheduleRow;
            if (scheduleForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var newSchedule = new Schedule(
                        0,
                        scheduleRow.UserId,
                        scheduleRow.DateJob,
                        scheduleRow.TimeStart,
                        scheduleRow.TimeEnd
                    );

                    if (ScheduleFromDb.AddScheduleRow(newSchedule))
                    {
                        schedule = ScheduleFromDb.GetScheduleView();
                        DG_SCHEDULE.DataSource = null;
                        DG_SCHEDULE.DataSource = schedule;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            if (DG_SCHEDULE.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для редактирования", "Внимание",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = DG_SCHEDULE.SelectedRows[0].DataBoundItem as ScheduleView;
            if (selectedRow == null) return;

            scheduleForm.ScheduleRow = selectedRow;
            if (scheduleForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var updatedSchedule = new Schedule(
                        selectedRow.Id,
                        selectedRow.UserId,
                        selectedRow.DateJob,
                        selectedRow.TimeStart,
                        selectedRow.TimeEnd
                    );

                    if (ScheduleFromDb.UpdateScheduleRow(updatedSchedule))
                    {
                        DG_SCHEDULE.DataSource = null;
                        DG_SCHEDULE.DataSource = schedule;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            if (DG_SCHEDULE.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для удаления", "Внимание",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = DG_SCHEDULE.SelectedRows[0].DataBoundItem as ScheduleView;
            if (selectedRow == null) return;

            var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?",
                                              "Подтверждение удаления",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    if (ScheduleFromDb.DeleteScheduleRow(selectedRow.Id))
                    {
                        schedule.Remove(selectedRow);
                        DG_SCHEDULE.DataSource = null;
                        DG_SCHEDULE.DataSource = schedule;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
