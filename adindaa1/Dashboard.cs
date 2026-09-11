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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
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
            pnlcontent.Controls.Clear();
            pnlcontent.Controls.Add(pnldashboard);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MasterUser DataUser = new MasterUser() { TopLevel = false, TopMost = true };
            KAdinda.warung(DataUser, pnlcontent);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            MasterRole DataUser = new MasterRole() { TopLevel = false, TopMost = true };
            KAdinda.warung(DataUser, pnlcontent);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Barang DataUser = new Barang() { TopLevel = false, TopMost = true };
            KAdinda.warung(DataUser, pnlcontent);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Kategori DataUser = new Kategori() { TopLevel = false, TopMost = true };
            KAdinda.warung(DataUser, pnlcontent);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Supplier DataUser = new Supplier() { TopLevel = false, TopMost = true };
            KAdinda.warung(DataUser, pnlcontent);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            BarangMasuk DataUser = new BarangMasuk() { TopLevel = false, TopMost = true };
            KAdinda.warung(DataUser, pnlcontent);
        }

        private void label16_Click(object sender, EventArgs e)
        {

            Penjualan DataUser = new Penjualan() { TopLevel = false, TopMost = true };
            KAdinda.warung(DataUser, pnlcontent);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Laporan DataUser = new Laporan() { TopLevel = false, TopMost = true };
            KAdinda.warung(DataUser, pnlcontent);
        }
    }
}
