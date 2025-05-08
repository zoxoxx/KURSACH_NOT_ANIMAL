using KURSACH_NOT_ANIMAL.Classes.DbClasses;
using KURSACH_NOT_ANIMAL.Classes.ViewClasses;
using KURSACH_NOT_ANIMAL.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Model
{
    public class ScheduleFromDb
    {
        public static List<Schedule>? GetSchedule()
        {
            List<Schedule>? schedule = new List<Schedule>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select * " +
                        "from SCHEDULE";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    while (reader.Read())
                        schedule.Add(new Schedule((int)reader[0], (int)reader[1], (DateOnly)reader[2], (TimeOnly)reader[3], (TimeOnly)reader[4]));
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при получении реестра расписания,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return schedule;
        }

        public static List<ScheduleView>? GetScheduleView()
        {
            List<ScheduleView>? schedule = new List<ScheduleView>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select s.*, u.PHYO " +
                        "from SCHEDULE s " +
                        "join USER_SYSTEM u on s.USER_ID = u.ID";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    while (reader.Read())
                        schedule.Add(new ScheduleView((int)reader[0], (int)reader[1], DateOnly.FromDateTime((DateTime)reader[2]), TimeOnly.FromDateTime((DateTime)reader[3]), TimeOnly.FromDateTime((DateTime)reader[4]), reader[5].ToString()));
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при получении реестра расписания,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return schedule;
        }

        public static Schedule? GetScheduleRow(int id)
        {
            Schedule? selectedScheduleRow = null;
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select * " +
                        "from SCHEDULE " +
                        "where ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Id", id);
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    reader.Read();
                    selectedScheduleRow = new Schedule((int)reader[0], (int)reader[1], (DateOnly)reader[2], (TimeOnly)reader[3], (TimeOnly)reader[4]);
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при поиске пункта расписания,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return selectedScheduleRow;
        }

        public static bool AddScheduleRow(Schedule schedule)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "INSERT INTO SCHEDULE(USER_ID, DATE_JOB, TIME_START, TIME_END) " +
                        "VALUES (@UserId, @DateJob, " +
                        "(@DateJob::date + @TimeStart::time)::timestamp, " + 
                        "(@DateJob::date + @TimeEnd::time)::timestamp)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("UserId", schedule.UserId);
                    cmd.Parameters.AddWithValue("DateJob", schedule.DateJob);
                    cmd.Parameters.AddWithValue("TimeStart", schedule.TimeStart.ToTimeSpan());
                    cmd.Parameters.AddWithValue("TimeEnd", schedule.TimeEnd.ToTimeSpan());

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при добавлении нового расписания,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool UpdateScheduleRow(Schedule changedSchedule)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "UPDATE SCHEDULE " +
                        "SET " +
                        "   USER_ID = @UserId, " +
                        "   DATE_JOB = @DateJob, " +
                        "   TIME_START = (@DateJob::date + @TimeStart::time)::timestamp, " +
                        "   TIME_END = (@DateJob::date + @TimeEnd::time)::timestamp " +
                        "WHERE ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Id", changedSchedule.Id);
                    cmd.Parameters.AddWithValue("UserId", changedSchedule.UserId);
                    cmd.Parameters.AddWithValue("DateJob", changedSchedule.DateJob);
                    cmd.Parameters.AddWithValue("TimeStart", changedSchedule.TimeStart.ToTimeSpan());
                    cmd.Parameters.AddWithValue("TimeEnd", changedSchedule.TimeEnd.ToTimeSpan());

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при обновлении расписания,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool DeleteScheduleRow(int scheduleId)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "DELETE FROM SCHEDULE " +
                        "WHERE ID = @ScheduleId";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("ScheduleId", scheduleId);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при удалении расписания,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
