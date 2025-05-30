using KURSACH_NOT_ANIMAL.Classes.DbClasses;
using KURSACH_NOT_ANIMAL.Forms.Admin;
using KURSACH_NOT_ANIMAL.Forms.Admin.ProductRes;
using KURSACH_NOT_ANIMAL.Forms.Admin.Shop;
using KURSACH_NOT_ANIMAL.Forms.Admin.Sklad;
using KURSACH_NOT_ANIMAL.Forms.Animal;
using KURSACH_NOT_ANIMAL.Forms.Reestr;

namespace KURSACH_NOT_ANIMAL
{
    internal static class Program
    {
        internal static AuthorizationForm StartForm { get; set; } = new AuthorizationForm();
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