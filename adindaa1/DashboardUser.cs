using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adindaa1
{
    public partial class DashboardUser : Form
    {
        public DashboardUser()
        {
            InitializeComponent();
        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            DialogResult setuju = MessageBox.Show("yakin mau keluar?", "pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (setuju == DialogResult.Yes)
            {
                Form1 dinda = new Form1();
                dinda.Visible = true;
                this.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
          
        }

        private void label7_Click(object sender, EventArgs e)
        {
            NotaUser DataUser = new NotaUser() { TopLevel = false, TopMost = true };
            KAdinda.warung(DataUser, panel4);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            LihatBarang DataUser = new LihatBarang() { TopLevel = false, TopMost = true };
            KAdinda.warung(DataUser, panel4);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            KategoriUser DataUser = new KategoriUser() { TopLevel = false, TopMost = true };
            KAdinda.warung(DataUser, panel4);
        }
    }
}
