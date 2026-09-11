using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Properties
{
    class KF
    {
        public static void untukform(Form Formluv, Panel PNLyou)
        {
            PNLyou.Controls.Clear();
            PNLyou.Controls.Add(Formluv);
            Formluv.FormBorderStyle = FormBorderStyle.None;
            Formluv.Dock = DockStyle.Fill;
            Formluv.Show();
        }
    }
}
