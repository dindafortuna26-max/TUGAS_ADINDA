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
    public partial class MasterUser : Form
    {
        public MasterUser()
        {
            InitializeComponent();
        }

        public void bersih()
        {
            txtnama.Text = "";
            txtuser.Text = "";
            txtpass.Text = "";
            cmbrole.Text = "";
        }

      

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            db.crud("SELECT * FROM tuser");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                string id = "" + baris["id"];
                string nm = "" + baris["nama"];
                string username = "" + baris["username"];
                string password = "" + baris["password"];
                string id_role = "" + baris["id_role"];
                dataGridView1.Rows.Add(id, nm, username, password, id_role);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string nm = txtnama.Text;
            string username = txtuser.Text;
            string password = Form1.MD5Hash(txtpass.Text);


            string role = cmbrole.SelectedValue.ToString();
            db.crud($"INSERT INTO tuser VALUES (null,'{nm}','{username}','{password}','{role}');");
            bersih();
            tampildata();
        }

        private void cmbrole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbrole_DropDown(object sender, EventArgs e)
        {
            db.crud("SELECT * FROM trole");

            cmbrole.DataSource = db.ds.Tables[0];
            cmbrole.DisplayMember = "nama_role";
            cmbrole.ValueMember = "id_role";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string nm = txtnama.Text;
            string user = txtuser.Text;
            string pass = Form1.MD5Hash(txtpass.Text);


            string role = cmbrole.SelectedValue.ToString();

            db.crud($"UPDATE tuser SET nama = '{nm}', username = '{user}', password = '{pass}', id_role = '{role}' WHERE ID = '{label1.Text}'");

            bersih();
            tampildata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            string idnya = dataGridView1.Rows[baris].Cells[0].Value.ToString();
            if (kolom == 5)
            {
                db.crud($"select * from tuser where ID = '{idnya}'");
                foreach (DataRow bariss in db.ds.Tables[0].Rows)
                {
                    string ID = "" + bariss["ID"];
                    string nm = "" + bariss["nama"];
                    string user = "" + bariss["username"];
                    string pass = "" + bariss["password"];
                    string role = "" + bariss["id_role"];
                    label1.Text = ID;
                    txtnama.Text = nm;
                    txtuser.Text = user;
                    txtpass.Text = pass;
                    cmbrole.Text = role;
                }

            }
            if (kolom == 6)
            {
                DialogResult ya = MessageBox.Show("apakah ingin menghapus data?", "pemberitahuan", MessageBoxButtons.YesNo);
                if (ya == DialogResult.Yes)
                {
                    db.crud($"DELETE FROM tuser WHERE ID = '{idnya}' ");
                    tampildata();
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            string idnya = dataGridView1.Rows[baris].Cells[0].Value.ToString();
            if (kolom == 5)
            {
                db.crud($"select * from tuser where ID = '{idnya}'");
                foreach (DataRow bariss in db.ds.Tables[0].Rows)
                {
                    string ID = "" + bariss["ID"];
                    string nm = "" + bariss["nama"];
                    string user = "" + bariss["username"];
                    string pass = "" + bariss["password"];
                    string role = "" + bariss["id_role"];
                    label1.Text = ID;
                    txtnama.Text = nm;
                    txtuser.Text = user;
                    txtpass.Text = pass;
                    cmbrole.SelectedValue = role;
                }

            }
            if (kolom == 6)
            {
                DialogResult ya = MessageBox.Show("apakah ingin menghapus data?", "pemberitahuan", MessageBoxButtons.YesNo);
                if (ya == DialogResult.Yes)
                {
                    db.crud($"DELETE FROM tuser WHERE ID = '{idnya}' ");
                    tampildata();
                }
            }
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
