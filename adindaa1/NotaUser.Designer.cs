
namespace adindaa1
{
    partial class NotaUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotaUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2dtTanggal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2CmbTransaksi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TxtKasir = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2TxtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2TxtKembali = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2TxtBayar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1Cetak = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(237)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.guna2Button1Cetak);
            this.panel1.Controls.Add(this.guna2TxtTotal);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.guna2TxtKembali);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.guna2TxtBayar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.guna2dtTanggal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.guna2CmbTransaksi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.guna2TxtKasir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 580);
            this.panel1.TabIndex = 0;
            // 
            // guna2dtTanggal
            // 
            this.guna2dtTanggal.Checked = true;
            this.guna2dtTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2dtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2dtTanggal.Location = new System.Drawing.Point(252, 136);
            this.guna2dtTanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2dtTanggal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2dtTanggal.Name = "guna2dtTanggal";
            this.guna2dtTanggal.Size = new System.Drawing.Size(144, 36);
            this.guna2dtTanggal.TabIndex = 56;
            this.guna2dtTanggal.Value = new System.DateTime(2026, 8, 28, 9, 44, 49, 69);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Kasir";
            // 
            // guna2CmbTransaksi
            // 
            this.guna2CmbTransaksi.BackColor = System.Drawing.Color.Transparent;
            this.guna2CmbTransaksi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2CmbTransaksi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2CmbTransaksi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CmbTransaksi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CmbTransaksi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2CmbTransaksi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2CmbTransaksi.ItemHeight = 30;
            this.guna2CmbTransaksi.Location = new System.Drawing.Point(92, 136);
            this.guna2CmbTransaksi.Name = "guna2CmbTransaksi";
            this.guna2CmbTransaksi.Size = new System.Drawing.Size(140, 36);
            this.guna2CmbTransaksi.TabIndex = 54;
            this.guna2CmbTransaksi.SelectedIndexChanged += new System.EventHandler(this.guna2CmbTransaksi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Tanggal";
            // 
            // guna2TxtKasir
            // 
            this.guna2TxtKasir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TxtKasir.DefaultText = "";
            this.guna2TxtKasir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TxtKasir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TxtKasir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtKasir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtKasir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtKasir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TxtKasir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtKasir.Location = new System.Drawing.Point(413, 126);
            this.guna2TxtKasir.Name = "guna2TxtKasir";
            this.guna2TxtKasir.PlaceholderText = "";
            this.guna2TxtKasir.ReadOnly = true;
            this.guna2TxtKasir.SelectedText = "";
            this.guna2TxtKasir.Size = new System.Drawing.Size(134, 36);
            this.guna2TxtKasir.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "No. Transaksi";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.label19.Location = new System.Drawing.Point(102, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 25);
            this.label19.TabIndex = 50;
            this.label19.Text = "Nota User";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(0, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(922, 243);
            this.dataGridView1.TabIndex = 57;
            // 
            // guna2TxtTotal
            // 
            this.guna2TxtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TxtTotal.DefaultText = "";
            this.guna2TxtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TxtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TxtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TxtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtTotal.Location = new System.Drawing.Point(580, 507);
            this.guna2TxtTotal.Name = "guna2TxtTotal";
            this.guna2TxtTotal.PlaceholderText = "";
            this.guna2TxtTotal.ReadOnly = true;
            this.guna2TxtTotal.SelectedText = "";
            this.guna2TxtTotal.Size = new System.Drawing.Size(134, 36);
            this.guna2TxtTotal.TabIndex = 66;
            this.guna2TxtTotal.TextChanged += new System.EventHandler(this.guna2TxtTotal_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(584, 484);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Total";
            // 
            // guna2TxtKembali
            // 
            this.guna2TxtKembali.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TxtKembali.DefaultText = "";
            this.guna2TxtKembali.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TxtKembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TxtKembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtKembali.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtKembali.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtKembali.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TxtKembali.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtKembali.Location = new System.Drawing.Point(435, 507);
            this.guna2TxtKembali.Name = "guna2TxtKembali";
            this.guna2TxtKembali.PlaceholderText = "";
            this.guna2TxtKembali.ReadOnly = true;
            this.guna2TxtKembali.SelectedText = "";
            this.guna2TxtKembali.Size = new System.Drawing.Size(134, 36);
            this.guna2TxtKembali.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Kembali";
            // 
            // guna2TxtBayar
            // 
            this.guna2TxtBayar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TxtBayar.DefaultText = "";
            this.guna2TxtBayar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TxtBayar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TxtBayar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtBayar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtBayar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtBayar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TxtBayar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtBayar.Location = new System.Drawing.Point(288, 507);
            this.guna2TxtBayar.Name = "guna2TxtBayar";
            this.guna2TxtBayar.PlaceholderText = "";
            this.guna2TxtBayar.ReadOnly = true;
            this.guna2TxtBayar.SelectedText = "";
            this.guna2TxtBayar.Size = new System.Drawing.Size(134, 36);
            this.guna2TxtBayar.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 481);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Bayar";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama Barang";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Harga";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Jumlah";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Subtotal";
            this.Column5.Name = "Column5";
            // 
            // guna2Button1Cetak
            // 
            this.guna2Button1Cetak.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1Cetak.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1Cetak.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1Cetak.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1Cetak.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1Cetak.ForeColor = System.Drawing.Color.White;
            this.guna2Button1Cetak.Location = new System.Drawing.Point(733, 511);
            this.guna2Button1Cetak.Name = "guna2Button1Cetak";
            this.guna2Button1Cetak.Size = new System.Drawing.Size(94, 27);
            this.guna2Button1Cetak.TabIndex = 67;
            this.guna2Button1Cetak.Text = "CETAK";
            this.guna2Button1Cetak.Click += new System.EventHandler(this.guna2Button1Cetak_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // NotaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 580);
            this.Controls.Add(this.panel1);
            this.Name = "NotaUser";
            this.Text = "NotaUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2dtTanggal;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox guna2CmbTransaksi;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TxtKasir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TxtTotal;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox guna2TxtKembali;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox guna2TxtBayar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI2.WinForms.Guna2Button guna2Button1Cetak;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}