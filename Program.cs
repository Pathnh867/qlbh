using System;
using System.Windows.Forms;

namespace QLBH
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            fLogin loginForm = new fLogin();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new fMain());
            }
        }
    }
}