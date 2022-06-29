using FileManager.Forms;
using FileManager.Infrastructure;
using System;
using System.Windows.Forms;

namespace FileManager
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            CompositionRoot compositionRoot = new CompositionRoot();
            AddServices(compositionRoot);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(compositionRoot.Get<MainForm>());
        }

        private static void AddServices(CompositionRoot compositionRoot)
        {
            compositionRoot.AddModule(new ServicesModule());
        }
    }
}