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
    public partial class Laporan : Form
    {
        public Laporan()
        {
            InitializeComponent();
        }

        public void tampilData()
        {
            dataGridView1.Rows.Clear();

            string dari = guna2DtDari.Value.ToString("yyyy-MM-dd");
            string sampai = guna2DtDari.Value.ToString("yyyy-MM-dd");

            db.crud(
                "SELECT id_penjualan, tanggal, id_user, total, bayar, kembalian " +
                "FROM tpenjualan " +
                $"WHERE tanggal BETWEEN '{dari}' AND '{sampai}' " +
                "ORDER BY id_penjualan ASC"
            );

            int no = 1;

            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                int total = Convert.ToInt32(baris["total"]);
                int bayar = Convert.ToInt32(baris["bayar"]);
                int kembali = Convert.ToInt32(baris["kembalian"]);

                dataGridView1.Rows.Add(
                    no,
                    baris["id_penjualan"].ToString(),
                    Convert.ToDateTime(baris["tanggal"]).ToString("dd/MM/yyyy"),
                    baris["id_user"].ToString(),
                    total.ToString("N0"),
                    bayar.ToString("N0"),
                    kembali.ToString("N0")
                );

                no++;
            }
        }

        public void hitungTotalPenjualan()
        {
            int total = 0;

            foreach (DataGridViewRow baris in dataGridView1.Rows)
            {
                if (baris.IsNewRow)
                    continue;

                if (baris.Cells[4].Value != null)
                {
                    string nilai = baris.Cells[4].Value.ToString();

                    nilai = nilai.Replace(".", "");
                    nilai = nilai.Replace(",", "");

                    total += Convert.ToInt32(nilai);
                }
            }

            txtTotalPenjualan.Text = total.ToString("N0");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btntampil_Click(object sender, EventArgs e)
        {
            tampilData();
            hitungTotalPenjualan();
        }

        private void txtTotalPenjualan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada data laporan untuk dicetak!");
                    return;
                }

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font judul = new Font("Arial", 16, FontStyle.Bold);
            Font font = new Font("Arial", 9);
            Font bold = new Font("Arial", 9, FontStyle.Bold);

            float y = 40;

            e.Graphics.DrawString(
                "LAPORAN PENJUALAN",
                judul,
                Brushes.Black,
                250,
                y
            );

            y += 40;

            string dari = guna2DtDari.Value.ToString("dd/MM/yyyy");
            string sampai = guna2DtSampai.Value.ToString("dd/MM/yyyy");

            e.Graphics.DrawString(
                "Periode : " + dari + " - " + sampai,
                font,
                Brushes.Black,
                50,
                y
            );

            y += 30;

            e.Graphics.DrawString(
                "--------------------------------------------------------------------------------",
                font,
                Brushes.Black,
                50,
                y
            );

            y += 25;

            e.Graphics.DrawString("No", bold, Brushes.Black, 50, y);
            e.Graphics.DrawString("Transaksi", bold, Brushes.Black, 85, y);
            e.Graphics.DrawString("Tanggal", bold, Brushes.Black, 160, y);
            e.Graphics.DrawString("Kasir", bold, Brushes.Black, 240, y);
            e.Graphics.DrawString("Total", bold, Brushes.Black, 300, y);
            e.Graphics.DrawString("Bayar", bold, Brushes.Black, 380, y);
            e.Graphics.DrawString("Kembali", bold, Brushes.Black, 460, y);

            y += 25;

            foreach (DataGridViewRow baris in dataGridView1.Rows)
            {
                if (baris.IsNewRow)
                    continue;

                e.Graphics.DrawString(
                    baris.Cells[0].Value.ToString(),
                    font,
                    Brushes.Black,
                    50,
                    y
                );

                e.Graphics.DrawString(
                    baris.Cells[1].Value.ToString(),
                    font,
                    Brushes.Black,
                    85,
                    y
                );

                e.Graphics.DrawString(
                    baris.Cells[2].Value.ToString(),
                    font,
                    Brushes.Black,
                    160,
                    y
                );

                e.Graphics.DrawString(
                    baris.Cells[3].Value.ToString(),
                    font,
                    Brushes.Black,
                    240,
                    y
                );

                e.Graphics.DrawString(
                    baris.Cells[4].Value.ToString(),
                    font,
                    Brushes.Black,
                    300,
                    y
                );

                e.Graphics.DrawString(
                    baris.Cells[5].Value.ToString(),
                    font,
                    Brushes.Black,
                    380,
                    y
                );

                e.Graphics.DrawString(
                    baris.Cells[6].Value.ToString(),
                    font,
                    Brushes.Black,
                    460,
                    y
                );

                y += 25;
            }

            y += 15;

            e.Graphics.DrawString(
                "--------------------------------------------------------------------------------",
                font,
                Brushes.Black,
                50,
                y
            );

            y += 30;

            e.Graphics.DrawString(
                "Total Penjualan : Rp " + txtTotalPenjualan.Text,
                bold,
                Brushes.Black,
                50,
                y
            );

            y += 40;

            e.Graphics.DrawString(
                "Laporan Penjualan",
                font,
                Brushes.Black,
                50,
                y
            );
        }
    }
    }

