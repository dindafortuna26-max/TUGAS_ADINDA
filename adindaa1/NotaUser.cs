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
    public partial class NotaUser : Form
    {
        public NotaUser()
        {
            InitializeComponent();
            guna2dtTanggal.Enabled = false;
            guna2TxtKasir.ReadOnly = true;
            guna2TxtTotal.ReadOnly = true;
            guna2TxtBayar.ReadOnly = true;
            guna2TxtKembali.ReadOnly = true;

            tampilNomorTransaksi();
        }

        public void tampilNomorTransaksi()
        {
            guna2CmbTransaksi.Items.Clear();

            db.crud("SELECT id_penjualan FROM tpenjualan ORDER BY id_penjualan ASC");

            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
               guna2CmbTransaksi.Items.Add(baris["id_penjualan"].ToString());
            }

           guna2CmbTransaksi.SelectedIndex = -1;
        }

        public void tampilDataNota(string noTransaksi)
        {
            dataGridView1.Rows.Clear();

            db.crud(
                "SELECT d.id_barang, b.nama_barang, d.harga, d.jumlah, d.subtotal " +
                "FROM tdetailpenjualan d " +
                "JOIN tbarang b ON d.id_barang = b.id_barang " +
                $"WHERE d.id_penjualan = '{noTransaksi}'"
            );

            int no = 1;

            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                int harga = Convert.ToInt32(baris["harga"]);
                int jumlah = Convert.ToInt32(baris["jumlah"]);
                int subtotal = Convert.ToInt32(baris["subtotal"]);

                dataGridView1.Rows.Add(
                    no,
                    baris["nama_barang"].ToString(),
                    harga.ToString("N0"),
                    jumlah,
                    subtotal.ToString("N0")
                );

                no++;
            }
        }

        public void tampilPembayaran(string noTransaksi)
        {
            db.crud(
                $"SELECT total, bayar, kembalian " +
                $"FROM tpenjualan " +
                $"WHERE id_penjualan = '{noTransaksi}'"
            );

            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                int total = Convert.ToInt32(baris["total"]);
                int bayar = Convert.ToInt32(baris["bayar"]);
                int kembali = Convert.ToInt32(baris["kembalian"]);

                guna2TxtTotal.Text = total.ToString("N0");
                guna2TxtBayar.Text = bayar.ToString("N0");
                guna2TxtKembali.Text = kembali.ToString("N0");
            }
        }

        private void guna2TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CmbTransaksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2CmbTransaksi.SelectedIndex == -1)
                return;

            string noTransaksi = guna2CmbTransaksi.Text;

            db.crud(
                $"SELECT tanggal, id_user " +
                $"FROM tpenjualan " +
                $"WHERE id_penjualan = '{noTransaksi}'"
            );

            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                guna2dtTanggal.Value = Convert.ToDateTime(baris["tanggal"]);
                guna2TxtKasir.Text = baris["id_user"].ToString();
            }

            tampilDataNota(noTransaksi);
            tampilPembayaran(noTransaksi);
        }

        private void guna2Button1Cetak_Click(object sender, EventArgs e)
        {
            if (guna2CmbTransaksi.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih nomor transaksi terlebih dahulu!");
                return;
            }

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font judul = new Font("Arial", 16, FontStyle.Bold);
            Font font = new Font("Arial", 10);
            Font bold = new Font("Arial", 10, FontStyle.Bold);

            float y = 40;

            e.Graphics.DrawString("NOTA PENJUALAN", judul, Brushes.Black, 100, y);
            y += 40;

            e.Graphics.DrawString("No. Transaksi : " + guna2CmbTransaksi.Text, font, Brushes.Black, 20, y);
            y += 25;

            e.Graphics.DrawString("Tanggal       : " + guna2dtTanggal.Text, font, Brushes.Black, 20, y);
            y += 25;

            e.Graphics.DrawString("Kasir         : " + guna2TxtKasir.Text, font, Brushes.Black, 20, y);
            y += 30;

            e.Graphics.DrawString("------------------------------------------", font, Brushes.Black, 20, y);
            y += 25;

            e.Graphics.DrawString("Barang", bold, Brushes.Black, 20, y);
            e.Graphics.DrawString("Harga", bold, Brushes.Black, 150, y);
            e.Graphics.DrawString("Qty", bold, Brushes.Black, 230, y);
            e.Graphics.DrawString("Subtotal", bold, Brushes.Black, 280, y);

            y += 25;

            foreach (DataGridViewRow baris in dataGridView1.Rows)
            {
                if (baris.IsNewRow)
                    continue;

                e.Graphics.DrawString(
                    baris.Cells[1].Value.ToString(),
                    font,
                    Brushes.Black,
                    20,
                    y
                );

                e.Graphics.DrawString(
                    baris.Cells[2].Value.ToString(),
                    font,
                    Brushes.Black,
                    150,
                    y
                );

                e.Graphics.DrawString(
                    baris.Cells[3].Value.ToString(),
                    font,
                    Brushes.Black,
                    230,
                    y
                );

                e.Graphics.DrawString(
                    baris.Cells[4].Value.ToString(),
                    font,
                    Brushes.Black,
                    280,
                    y
                );

                y += 25;
            }

            y += 15;

            e.Graphics.DrawString("------------------------------------------", font, Brushes.Black, 20, y);
            y += 25;

            e.Graphics.DrawString("Total      : " + guna2TxtTotal.Text, bold, Brushes.Black, 20, y);
            y += 25;

            e.Graphics.DrawString("Bayar      : " + guna2TxtBayar.Text, font, Brushes.Black, 20, y);
            y += 25;

            e.Graphics.DrawString("Kembalian  : " + guna2TxtKembali.Text, font, Brushes.Black, 20, y);
            y += 40;

            e.Graphics.DrawString("Terima kasih telah berbelanja!", font, Brushes.Black, 70, y);
        }
    }
}
