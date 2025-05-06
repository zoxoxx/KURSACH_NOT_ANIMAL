using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.SystemClasses
{
    public static class Logger
    {
        private static readonly string logFilePath;

        static Logger()
        {
            var parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory);
            if (parentDirectory != null)
            {
                var solutionDirectory = parentDirectory.Parent;
                if (solutionDirectory != null)
                    logFilePath = Path.Combine(solutionDirectory.FullName, "application.log");
                else
                    throw new Exception("Не удалось найти каталог решения.");
            }
            else
                throw new Exception("Не удалось получить родительский каталог.");
        }

        public static void Log(string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now}: {message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка записи в лог: {ex.Message}");
            }
        }
    }
}
