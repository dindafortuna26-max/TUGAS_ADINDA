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
    public partial class MasterRole : Form
    {
        public MasterRole()
        {
            InitializeComponent();
        }

        public void bersih()
        {
            txtnamarole.Text = "";
          
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            db.crud("SELECT * FROM trole");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_role"];
                string nm = "" + baris["nama_role"];
                dataGridView1.Rows.Add(id, nm);
            }

          
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string nama_role = txtnamarole.Text;
            db.crud($"INSERT INTO trole (nama_role) VALUES ('{nama_role}')");
            bersih();
            tampildata();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string nm = txtnamarole.Text;
            db.crud($"UPDATE trole SET nama_role = '{txtnamarole.Text}' WHERE id_role = '{lbl1.Text}'");
            bersih();
            tampildata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;

            string idnya = dataGridView1.Rows[baris].Cells[0].Value.ToString();

            if (kolom == 2) 
            {
                db.crud($"SELECT * FROM trole WHERE id_role='{idnya}'");

                foreach (DataRow bariss in db.ds.Tables[0].Rows)
                {
                    lbl1.Text = bariss["id_role"].ToString();
                    txtnamarole.Text = bariss["nama_role"].ToString();
                }
            }

            if (kolom == 3) 
            {
                DialogResult ya = MessageBox.Show("Apakah ingin menghapus data?", "Pemberitahuan", MessageBoxButtons.YesNo);

                if (ya == DialogResult.Yes)
                {
                    db.crud($"DELETE FROM trole WHERE id_role='{idnya}'");
                    tampildata();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            tampildata();
        }
    }
        }
  
