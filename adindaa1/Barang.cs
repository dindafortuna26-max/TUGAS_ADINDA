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
    public partial class Barang : Form
    {
        public Barang()
        {
            InitializeComponent();
        }

        public void bersih()
        {
            guna2TxtBarcode.Text = "";
            guna2Txtnmbarang.Text = "";
            guna2CmbKategori.Text = "";
            guna2CmbSupplier.Text = "";
            guna2TxtHarbeli.Text = "";
            guna2TxtHarjul.Text = "";
            guna2TxtStok.Text = "";
            guna2TxtSatuan.Text = "";
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            db.crud("SELECT * FROM tbarang");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_barang"];
                string barcode = "" + baris["barcode"];
                string nama = "" + baris["nama_barang"];
                string kategori = "" + baris["id_kategori"];
                string supplier = "" + baris["id_supplier"];
                int hargaBeli = Convert.ToInt32(baris["harga_beli"]);
                string hargaBeliformat = hargaBeli.ToString("N0");
                int hargaJual = Convert.ToInt32(baris["harga_jual"]);
                string hargaJualformat = hargaJual.ToString("N0");
                string stok = "" + baris["stok"];
                string satuan = "" + baris["satuan"];
                dataGridView1.Rows.Add(id, barcode, nama, kategori, supplier, hargaBeliformat, hargaJualformat, stok, satuan);
            }
        }



        private void guna2TxtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string barcode = guna2TxtBarcode.Text;
            string nama = guna2Txtnmbarang.Text;
            string kategori = guna2CmbKategori.SelectedValue.ToString();
            string supplier = guna2CmbSupplier.SelectedValue.ToString();
            string hargaBeli = guna2TxtHarbeli.Text;
            string hargaJual = guna2TxtHarjul.Text;
            string stok = guna2TxtStok.Text;
            string satuan = guna2TxtSatuan.Text;
            db.crud($"INSERT INTO tbarang VALUES(null,'{barcode}', '{nama}', '{kategori}', '{supplier}', '{hargaBeli}', '{hargaJual}', '{stok}', '{satuan}');");
            tampildata();
            bersih();
        }

        private void guna2CmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string barcode = guna2TxtBarcode.Text;
            string nama = guna2Txtnmbarang.Text;
            string kategori = guna2CmbKategori.SelectedValue.ToString();
            string supplier = guna2CmbSupplier.SelectedValue.ToString();
            string hargaBeli = guna2TxtHarbeli.Text;
            string hargaJual = guna2TxtHarjul.Text;
            string stok = guna2TxtStok.Text;
            string satuan = guna2TxtSatuan.Text;
            string idb = nomor.Text;
            db.crud($"UPDATE tbarang SET barcode = '{barcode}', nama_barang =  '{nama}', id_kategori = '{kategori}', id_supplier = '{supplier}', harga_beli = '{hargaBeli}', harga_jual =  '{hargaJual}', stok = '{stok}', satuan = '{satuan}' where id_barang = '{idb}'");
            tampildata();
            bersih();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            string idnya = dataGridView1.Rows[baris].Cells[0].Value.ToString();
            if (kolom == 9)
            {
                db.crud($"select * from tbarang where id_barang = '{idnya}'");
                foreach (DataRow bariss in db.ds.Tables[0].Rows)
                {
                    string id = "" + bariss["id_barang"];
                    string barcode = "" + bariss["barcode"];
                    string nm = "" + bariss["nama_barang"];
                    string kategori = "" + bariss["id_kategori"].ToString();
                    string supp = "" + bariss["id_supplier"].ToString();
                    string harbeli = "" + bariss["harga_beli"];
                    string harjul = "" + bariss["harga_jual"];
                    string stok = "" + bariss["stok"];
                    string satuan = "" + bariss["satuan"];
                    nomor.Text = id;
                    guna2TxtBarcode.Text = barcode;
                    guna2Txtnmbarang.Text = nm;
                    guna2CmbKategori.SelectedValue = kategori;
                    guna2CmbSupplier.SelectedValue = supp;
                    guna2TxtHarbeli.Text = harbeli;
                    guna2TxtHarjul.Text = harjul;
                    guna2TxtStok.Text = stok;   
                    guna2TxtSatuan.Text = satuan;

                }

            }
            if (kolom == 10)
            {
                DialogResult ya = MessageBox.Show("apakah ingin menghapus data?", "pemberitahuan", MessageBoxButtons.YesNo);
                if (ya == DialogResult.Yes)
                {
                    db.crud($"DELETE FROM tbarang WHERE id_barang = '{idnya}' ");
                    tampildata();
                }
            }
        }

     
          private void Barang_Load(object sender, EventArgs e)
        {
            db.crud("SELECT * FROM tkategori");

            guna2CmbKategori.DataSource = db.ds.Tables[0];
            guna2CmbKategori.DisplayMember = "nama_kategori";
            guna2CmbKategori.ValueMember = "id_kategori";

            db.crud("SELECT * FROM tsupplier");
            guna2CmbSupplier.DataSource = db.ds.Tables[0];
            guna2CmbSupplier.DisplayMember = "nama_supplier";
            guna2CmbSupplier.ValueMember = "id_supplier";
        }

        private void guna2TxtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void guna2TxtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string barcode = guna2TxtBarcode.Text.Trim();

                if (barcode == "")
                {
                    return;
                }

                db.crud($"SELECT * FROM tbarang WHERE barcode = '{barcode}'");

                if (db.ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow baris in db.ds.Tables[0].Rows)
                    {
                        label1.Text = "" + baris["id_barang"];
                        guna2TxtBarcode.Text = "" + baris["barcode"];
                        guna2Txtnmbarang.Text = "" + baris["nama_barang"];
                        guna2CmbKategori.Text = "" + baris["id_kategori"];
                        guna2CmbSupplier.Text = "" + baris["id_supplier"];
                        guna2TxtHarbeli.Text = "" + baris["harga_beli"];
                        guna2TxtHarjul.Text = "" + baris["harga_jual"];
                        guna2TxtStok.Text = "" + baris["stok"];
                        guna2TxtSatuan.Text = "" + baris["satuan"];
                    }
                }
                else
                {
                    // Barcode baru, langsung lanjut isi nama barang
                    guna2Txtnmbarang.Focus();
                }

                e.Handled = true;
            }
        }

        private void guna2CmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nomor_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

