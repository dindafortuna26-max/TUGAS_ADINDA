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
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }

        public void bersih()
        {
            guna2TxtNamaKategori.Text = "";
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            db.crud("SELECT * FROM tkategori");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_kategori"];
                string nama = "" + baris["nama_kategori"];
                dataGridView1.Rows.Add(id, nama);
            }
        }

        private void guna2BtnSimpan_Click(object sender, EventArgs e)
        {

            string nama = guna2TxtNamaKategori.Text;
            db.crud($"INSERT INTO tkategori VALUES(null, '{nama}');");
            tampildata();
            bersih();
        }

        private void guna2BtnTampil_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void nomor_Click(object sender, EventArgs e)
        {

        }

        private void guna2BtnUpdate_Click(object sender, EventArgs e)
        {
            string nama = guna2TxtNamaKategori.Text;
            string id_kategori = nomor.Text;
            db.crud($"UPDATE tkategori SET nama_kategori = '{nama}' where id_kategori = '{id_kategori}'");
            tampildata();
            bersih();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            string idnya = dataGridView1.Rows[baris].Cells[0].Value.ToString();
            if (kolom == 2)
            {
                db.crud($"select * from tkategori where id_kategori = '{idnya}'");
                foreach (DataRow bariss in db.ds.Tables[0].Rows)
                {
                    string id = "" + bariss["id_kategori"];
                    string nm = "" + bariss["nama_kategori"];
                    nomor.Text = id;
                    guna2TxtNamaKategori.Text = nm;

                }

            }
            if (kolom == 3)
            {
                DialogResult ya = MessageBox.Show("apakah ingin menghapus data?", "pemberitahuan", MessageBoxButtons.YesNo);
                if (ya == DialogResult.Yes)
                {
                    db.crud($"DELETE FROM tkategori WHERE id_kategori = '{idnya}' ");
                    tampildata();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

