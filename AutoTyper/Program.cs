using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTyper
{
    internal static class Program
    {
        public static ApplicationContext AppContext { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppContext = new ApplicationContext(new Form1());
            Application.Run(AppContext);
        }
    }
}
