using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISTTP_Lab2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AuthorizationForm authorizationForm = new AuthorizationForm();
            Application.Run(authorizationForm);
            if(authorizationForm.success)
            {
                Application.Run(new DBUIForm());
            }
        }
    }
}
