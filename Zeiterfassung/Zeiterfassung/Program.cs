using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Zeiterfassung
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SqlConnection.GetConnection();
            Application.Run(new Hauptmaske());
        }
    }
}
