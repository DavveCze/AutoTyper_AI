using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTyper
{
    public static class FormChanger
    {
        public static void SwitchMainForm(Form newForm)
        {
            var oldMainForm = Program.AppContext.MainForm;
            Program.AppContext.MainForm = newForm;
            oldMainForm?.Close();
            newForm.Show();
        }
    }
}
