using NguyenHungPhat68PM3;
using System;
using System.Windows.Forms;

namespace NguyenHungPhat68PM3
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginForm());
        }
    }
}