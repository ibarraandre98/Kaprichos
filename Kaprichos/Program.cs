using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaprichos
{
    static class Program
    {
        //Privilegios
        public static String cargo;
        public static String usuario;
        public static String contraseña;
        public static String nombre;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login log = new Login();
            log.Show();
            Application.Run();
        }
    }
}
