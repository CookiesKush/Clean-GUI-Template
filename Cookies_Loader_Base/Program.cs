using System;
using System.Windows.Forms;

namespace Cookies_Loader_Base
{
    static class Program
    {
        /*
         * 
         * How to setup keyauth here
         * 
         * https://www.youtube.com/watch?v=Eyzuka6r1Ew
         */
        [STAThread]
        static void Main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
