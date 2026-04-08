using System;
using System.Windows.Forms;

namespace DataDrivenApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    var userRights = loginForm.AuthorizedUser;
                    Application.Run(new MainForm(userRights, "menu.txt"));
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}