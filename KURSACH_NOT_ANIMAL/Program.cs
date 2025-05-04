using KURSACH_NOT_ANIMAL.Forms.Reestr;

namespace KURSACH_NOT_ANIMAL
{
    internal static class Program
    {
        internal static AnimalReestr StartForm { get; set; } = new AnimalReestr();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(StartForm);
        }
    }
}