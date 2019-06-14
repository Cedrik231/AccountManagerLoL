using System;
using System.Windows.Forms;

namespace AccountManager
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AccountController.CheckUser();            
            Application.Run(new Main());
        }
    }
}
