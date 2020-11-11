using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduWatch
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
            /*
            var loginForm = new Views.LoginForm();
            var loginPresenter = new Presenters.LoginPresenter(loginForm, new Model.SchoolDBEntities());
            Application.Run(loginForm);
            */

        }
    }
}
