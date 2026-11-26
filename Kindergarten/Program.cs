using System;
using System.Windows.Forms;

namespace Kindergarten
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DataStorage.Load();
            Application.Run(new Form1());
        }
    }
}
