using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista
{
    static class Program
    {
        /// <summary>
        ///  Punto de entrada principal para la aplicación
        /// </summary>

        public static Form1 form1;
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form1 = new Form1());
        }
    }
}
