using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinguaLearn
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //User a = new User("", "", ""); 
            //Application.Run(new mainForm(a));
            //Application.Run(new GrammerForm());
            Application.Run(new matchingForm());
            //Application.Run(new LoginForm());
        }
    }
}
