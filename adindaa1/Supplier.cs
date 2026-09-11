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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }
        public void bersih()
        {
            guna2Txtnmsupplier.Text = "";
            guna2Txtalamat.Text = "";
            guna2TxtNohp.Text = "";
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            db.crud("SELECT * FROM tsupplier");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_supplier"];
                string nama = "" + baris["nama_supplier"];
                string alamat = "" + baris["alamat"];
                string no = "" + baris["no_hp"];
                dataGridView1.Rows.Add(id, nama, alamat, no);
            }
        }
        private void guna2BtnSimpanSupplier_Click(object sender, EventArgs e)
        {
            string nama = guna2Txtnmsupplier.Text;
            string alamat = guna2Txtalamat.Text;
            string no = guna2TxtNohp.Text;
            db.crud($"INSERT INTO tsupplier VALUES(null, '{nama}', '{alamat}', '{no}');");
            tampildata();
            bersih();
        }

        private void guna2BtnUpdate_Click(object sender, EventArgs e)
        {
            string nama = guna2Txtnmsupplier.Text;
            string id_supplier = nomor.Text;
            string alamat = guna2Txtalamat.Text;
            string no = guna2TxtNohp.Text;
            db.crud($"UPDATE tsupplier SET nama_supplier = '{nama}', alamat = '{alamat}', no_hp = '{no}' where id_supplier = '{id_supplier}'");
            tampildata();
            bersih();
        }

        private void guna2BtnTampil_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            string idnya = dataGridView1.Rows[baris].Cells[0].Value.ToString();
            if (kolom == 4)
            {
                db.crud($"select * from tsupplier where id_supplier = '{idnya}'");
                foreach (DataRow bariss in db.ds.Tables[0].Rows)
                {
                    string id = "" + bariss["id_supplier"];
                    string nm = "" + bariss["nama_supplier"];
                    string alamat = "" + bariss["alamat"];
                    string no = "" + bariss["no_hp"];
                    nomor.Text = id;
                    guna2Txtnmsupplier.Text = nm;
                    guna2Txtalamat.Text = alamat;
                    guna2TxtNohp.Text = no;

                }

            }
            if (kolom == 5)
            {
                DialogResult ya = MessageBox.Show("apakah ingin menghapus data?", "pemberitahuan", MessageBoxButtons.YesNo);
                if (ya == DialogResult.Yes)
                {
                    db.crud($"DELETE FROM tsupplier WHERE id_supplier = '{idnya}' ");
                    tampildata();
                }
            }
        }
    }
}
    
