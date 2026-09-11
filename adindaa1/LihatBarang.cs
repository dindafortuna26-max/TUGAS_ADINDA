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
    public partial class LihatBarang : Form
    {
        public LihatBarang()
        {
            InitializeComponent();

            tampilData();
        }

        public void tampilData()
        {
            dataGridView1.Rows.Clear();

            db.crud(
                "SELECT b.nama_barang, b.harga_jual, k.nama_kategori, b.stok " +
                "FROM tbarang b " +
                "JOIN tkategori k ON b.id_kategori = k.id_kategori"
            );

            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                int harga = Convert.ToInt32(baris["harga_jual"]);

                dataGridView1.Rows.Add(
                    baris["nama_barang"].ToString(),
                    harga.ToString("N0"),
                    baris["nama_kategori"].ToString(),
                    baris["stok"].ToString()
                );
            }
        }



        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void guna2TxtCariBarang_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string cari = guna2TxtCariBarang.Text;

            db.crud(
                "SELECT b.nama_barang, b.harga_jual, k.nama_kategori, b.stok " +
                "FROM tbarang b " +
                "JOIN tkategori k ON b.id_kategori = k.id_kategori " +
                $"WHERE b.nama_barang LIKE '%{cari}%'"
            );

            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                int harga = Convert.ToInt32(baris["harga_jual"]);

                dataGridView1.Rows.Add(
                    baris["nama_barang"].ToString(),
                    harga.ToString("N0"),
                    baris["nama_kategori"].ToString(),
                    baris["stok"].ToString()
                );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string namaBarang = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            db.crud(
                "SELECT b.nama_barang, b.harga_jual, k.nama_kategori, b.stok " +
                "FROM tbarang b " +
                "JOIN tkategori k ON b.id_kategori = k.id_kategori " +
                $"WHERE b.nama_barang = '{namaBarang}'"
            );

            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                guna2TxtNamaBarang.Text = baris["nama_barang"].ToString();

                int harga = Convert.ToInt32(baris["harga_jual"]);
                guna2TxtHarga.Text = harga.ToString("N0");

                guna2TxtKategori.Text = baris["nama_kategori"].ToString();
                guna2TxtStok.Text = baris["stok"].ToString();
            }
        }

        private void guna2TxtStok_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
