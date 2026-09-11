using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adindaa1
{
    internal class KAdinda
    {
        public static void warung(Form formdashboard, Panel pnlapa)
        {
            pnlapa.Controls.Clear();
            pnlapa.Controls.Add(formdashboard);
            formdashboard.FormBorderStyle = FormBorderStyle.None;
            formdashboard.Dock = DockStyle.Fill;
            formdashboard.Show();
        }
    }
}
