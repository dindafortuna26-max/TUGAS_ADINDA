using Guna.UI2.WinForms;
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
    public partial class Penjualan : Form
    {
        public Penjualan()
        {
            InitializeComponent();

            guna2dtTanggal.Value = DateTime.Now;
            guna2dtTanggal.Enabled = false;
            guna2TxtTransaksi.ReadOnly = true;
            guna2TxtHarga.ReadOnly = true;
            guna2TxtTotal.ReadOnly = true;
            guna2TxtKembali.ReadOnly = true;

            nomorTransaksi();
           
        }

        public void nomorTransaksi()
        {
            db.crud("SELECT IFNULL(MAX(id_penjualan), 0) + 1 AS nomor FROM tpenjualan");

            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                string nomorTrx = "" + baris["nomor"];
                guna2TxtTransaksi.Text = nomorTrx;
            }
        }


        public void hitungTotal()
        {
            int total = 0;

            foreach (DataGridViewRow baris in dataGridView1.Rows)
            {
                if (baris.IsNewRow)
                    continue;

                if (baris.Cells[5].Value != null)
                {
                    string subtotal = baris.Cells[5].Value.ToString();

                    subtotal = subtotal.Replace(".", "");
                    subtotal = subtotal.Replace(",", "");

                    total += Convert.ToInt32(subtotal);
                }
            }

            guna2TxtTotal.Text = total.ToString("N0");
        }


        public void bersih()
        {
            guna2CmbKasir.Text = "";
            guna2CmbBarang.Text = "";
            guna2TxtHarga.Text = "";
            guna2TxtQty.Text = "";
            guna2TxtTotal.Text = "";
            guna2TxtBayar.Text = "";
            guna2TxtKembali.Text = "";
            nomor.Text = "";

            nomorTransaksi();
            tampildata();
        }

        public void tampilbarang()
        {
            db.crud("SELECT * FROM tbarang");

            guna2CmbBarang.DataSource = db.ds.Tables[0];
            guna2CmbBarang.DisplayMember = "nama_barang";
            guna2CmbBarang.ValueMember = "id_barang";
            guna2CmbBarang.SelectedIndex = -1;
        }
        public void tampilkasir()
        {
            guna2CmbKasir.Items.Clear();

            db.crud("SELECT * FROM tuser");

            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                guna2CmbKasir.Items.Add(baris["id"].ToString());
            }
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();

            string noTransaksi = guna2TxtTransaksi.Text;

            if (noTransaksi == "")
                return;

            db.crud("SELECT d.id_detail, d.id_barang, b.nama_barang, d.harga, d.jumlah, d.subtotal " +
                    "FROM tdetailpenjualan d " +
                    "JOIN tbarang b ON d.id_barang = b.id_barang " +
                    $"WHERE d.id_penjualan = '{noTransaksi}'");

            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                string idDetail = "" + baris["id_detail"];
                string idBarang = "" + baris["id_barang"];
                string namaBarang = "" + baris["nama_barang"];

                int harga = Convert.ToInt32(baris["harga"]);
                string hargaFormat = harga.ToString("N0");

                string jumlah = "" + baris["jumlah"];

                int subtotal = Convert.ToInt32(baris["subtotal"]);
                string subtotalFormat = subtotal.ToString("N0");

                dataGridView1.Rows.Add(
                    idDetail,
                    idBarang,
                    namaBarang,
                    hargaFormat,
                    jumlah,
                    subtotalFormat
                );
            }
        }


        private void guna2CmbBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2CmbBarang.SelectedValue == null)
            {
                guna2TxtHarga.Text = "";
                return;
            }

            DataRowView baris = (DataRowView)guna2CmbBarang.SelectedItem;
            guna2TxtHarga.Text = baris["harga_jual"].ToString();
        }

        private void Penjualan_Load(object sender, EventArgs e)
        {
            tampilbarang();
            tampilkasir();

            guna2dtTanggal.Value = DateTime.Now;
        }

        private void guna2TxtTransaksi_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2BTNtambah_Click(object sender, EventArgs e)
        {
            string idBarang = guna2CmbBarang.SelectedValue.ToString();
            string namaBarang = guna2CmbBarang.Text;
            string harga = guna2TxtHarga.Text;
            string jumlah = guna2TxtQty.Text;

            int hargaInt = Convert.ToInt32(harga);
            int jumlahInt = Convert.ToInt32(jumlah);
            int subtotal = hargaInt * jumlahInt;

            string noTransaksi = guna2TxtTransaksi.Text;

            // INSERT ke tdetailpenjualan
            db.crud($"INSERT INTO tdetailpenjualan (id_penjualan, id_barang, harga, jumlah, subtotal) " +
                    $"VALUES ('{noTransaksi}', '{idBarang}', '{hargaInt}', '{jumlahInt}', '{subtotal}')");

            tampildata();   // reload grid langsung dari DB (bukan Rows.Add manual)
            hitungTotal();

            guna2CmbBarang.Text = "";
            guna2TxtHarga.Text = "";
            guna2TxtQty.Text = "";
        }

        private void guna2TxtBayar_KeyUp(object sender, KeyEventArgs e)
        {
            int total = 0;
            int bayar = 0;

            if (guna2TxtTotal.Text != "")
            {
                total = Convert.ToInt32(
                    guna2TxtTotal.Text.Replace(".", "").Replace(",", "")
                );
            }

            if (guna2TxtBayar.Text != "")
            {
                bayar = Convert.ToInt32(
                    guna2TxtBayar.Text.Replace(".", "").Replace(",", "")
                );
            }

            if (bayar >= total)
            {
                guna2TxtKembali.Text = (bayar - total).ToString("N0");
            }
            else
            {
                guna2TxtKembali.Text = "0";
            }

        }

        private void guna2TxtBayar_TextChanged(object sender, EventArgs e)
        {
            decimal total = 0;
            decimal bayar = 0;

            decimal.TryParse(guna2TxtTotal.Text, out total);
            decimal.TryParse(guna2TxtBayar.Text, out bayar);

            if (bayar >= total)
            {
                decimal kembali = bayar - total;
                guna2TxtKembali.Text = kembali.ToString("0", System.Globalization.CultureInfo.InvariantCulture);
            }
            else
            {
                guna2TxtKembali.Text = "0";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TxtQty_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string idDetail = nomor.Text;   // ✅ pakai ini, bukan guna2TxtTransaksi.Text

            if (idDetail == "")
            {
                MessageBox.Show("Pilih dulu data yang mau diupdate (klik icon edit di grid)");
                return;
            }

            string idBarang = guna2CmbBarang.SelectedValue.ToString();
            string harga = guna2TxtHarga.Text.Replace(".", "").Replace(",", "");
            string jumlah = guna2TxtQty.Text;

            int hargaInt = Convert.ToInt32(harga);
            int jumlahInt = Convert.ToInt32(jumlah);
            int subtotal = hargaInt * jumlahInt;

            db.crud($"UPDATE tdetailpenjualan SET " +
                    $"id_barang = '{idBarang}', " +
                    $"harga = '{hargaInt}', " +
                    $"jumlah = '{jumlahInt}', " +
                    $"subtotal = '{subtotal}' " +
                    $"WHERE id_detail = '{idDetail}'");

            tampildata();
            hitungTotal();
            nomor.Text = "";

            MessageBox.Show("Data berhasil diupdate");
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;


            string idDetail = dataGridView1.Rows[baris].Cells[0].Value.ToString();

            // UPDATE: isi form dari baris yang diklik
            if (kolom == 6)
            {
                db.crud($"SELECT * FROM tdetailpenjualan WHERE id_detail = '{idDetail}'");

                foreach (DataRow bariss in db.ds.Tables[0].Rows)
                {

                    string idBarang = "" + bariss["id_barang"];
                    int harga = Convert.ToInt32(bariss["harga"]);
                    string jumlah = "" + bariss["jumlah"];

                    nomor.Text = idDetail;
                    guna2CmbBarang.SelectedValue = idBarang;
                    guna2TxtHarga.Text = harga.ToString("N0");
                    guna2TxtQty.Text = jumlah;
                }
            }

            // DELETE
            if (kolom == 7)
            {
                DialogResult ya = MessageBox.Show(
                    "Apakah ingin menghapus data ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo);

                if (ya == DialogResult.Yes)
                {
                    db.crud($"DELETE FROM tdetailpenjualan WHERE id_detail = '{idDetail}'");

                    tampildata();
                    hitungTotal();
                }

            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
          
            if (guna2TxtTransaksi.Text == "")
            {
                MessageBox.Show("Masukkan nomor transaksi dulu");
                return;
            }

            tampildata();
            hitungTotal();
        }
        

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TxtHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1Bayar_Click(object sender, EventArgs e)
        {
            string noTransaksi = guna2TxtTransaksi.Text;
            string tanggal = guna2dtTanggal.Value.ToString("yyyy-MM-dd");
            string kasir = guna2CmbKasir.Text;

            if (noTransaksi == "")
            {
                MessageBox.Show("Nomor transaksi belum tersedia!");
                return;
            }

            if (kasir == "")
            {
                MessageBox.Show("Pilih kasir terlebih dahulu!");
                return;
            }

            if (guna2TxtBayar.Text == "")
            {
                MessageBox.Show("Masukkan jumlah bayar!");
                guna2TxtBayar.Focus();
                return;
            }

           
            string totalText = guna2TxtTotal.Text
                .Replace(".", "")
                .Replace(",", "")
                .Trim();

            string bayarText = guna2TxtBayar.Text
                .Replace(".", "")
                .Replace(",", "")
                .Trim();

            int total = Convert.ToInt32(totalText);
            int bayar = Convert.ToInt32(bayarText);

            if (bayar < total)
            {
                MessageBox.Show("Uang bayar kurang!");
                return;
            }

            int kembali = bayar - total;

           
            guna2TxtKembali.Text = kembali.ToString("N0");

           
            db.crud(
                $"INSERT INTO tpenjualan " +
                $"(id_penjualan, tanggal, id_user, total, bayar, kembalian) " +
                $"VALUES " +
                $"('{noTransaksi}', '{tanggal}', '{kasir}', '{total}', '{bayar}', '{kembali}')"
            );

            MessageBox.Show(
                "Pembayaran berhasil!\n" +
                "No. Transaksi : " + noTransaksi +
                "\nTotal : " + total.ToString("N0") +
                "\nBayar : " + bayar.ToString("N0") +
                "\nKembali : " + kembali.ToString("N0"),
                "Transaksi Berhasil"
            );

            bersih();
        }
    }
}
    


