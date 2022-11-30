using System;
using System.Windows.Forms;

namespace Lab6
{
    static class Program
    {
        // заменить list на linkedlist, написать для linkedlist findall, загрузка из файла input, переделать класс на свой, свои фильтры
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
