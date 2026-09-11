
namespace adindaa1
{
    partial class Laporan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laporan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPenjualan = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btntampil = new System.Windows.Forms.Button();
            this.guna2DtSampai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DtDari = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.btnCetak = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(237)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.btnCetak);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTotalPenjualan);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btntampil);
            this.panel1.Controls.Add(this.guna2DtSampai);
            this.panel1.Controls.Add(this.guna2DtDari);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 576);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(596, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total Penjualan";
            // 
            // txtTotalPenjualan
            // 
            this.txtTotalPenjualan.Location = new System.Drawing.Point(732, 291);
            this.txtTotalPenjualan.Name = "txtTotalPenjualan";
            this.txtTotalPenjualan.ReadOnly = true;
            this.txtTotalPenjualan.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPenjualan.TabIndex = 13;
            this.txtTotalPenjualan.TextChanged += new System.EventHandler(this.txtTotalPenjualan_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(895, 250);
            this.dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "No Transaksi";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tanggal";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kasir";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Bayar";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Kembalian";
            this.Column7.Name = "Column7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sampai Tanggal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dari Tanggal";
            // 
            // btntampil
            // 
            this.btntampil.Location = new System.Drawing.Point(321, 234);
            this.btntampil.Name = "btntampil";
            this.btntampil.Size = new System.Drawing.Size(75, 23);
            this.btntampil.TabIndex = 9;
            this.btntampil.Text = "TAMPIL";
            this.btntampil.UseVisualStyleBackColor = true;
            this.btntampil.Click += new System.EventHandler(this.btntampil_Click);
            // 
            // guna2DtSampai
            // 
            this.guna2DtSampai.Checked = true;
            this.guna2DtSampai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DtSampai.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DtSampai.Location = new System.Drawing.Point(81, 223);
            this.guna2DtSampai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DtSampai.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DtSampai.Name = "guna2DtSampai";
            this.guna2DtSampai.Size = new System.Drawing.Size(176, 34);
            this.guna2DtSampai.TabIndex = 8;
            this.guna2DtSampai.Value = new System.DateTime(2026, 9, 4, 9, 24, 35, 782);
            // 
            // guna2DtDari
            // 
            this.guna2DtDari.Checked = true;
            this.guna2DtDari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DtDari.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DtDari.Location = new System.Drawing.Point(79, 147);
            this.guna2DtDari.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DtDari.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DtDari.Name = "guna2DtDari";
            this.guna2DtDari.Size = new System.Drawing.Size(178, 30);
            this.guna2DtDari.TabIndex = 7;
            this.guna2DtDari.Value = new System.DateTime(2026, 9, 4, 9, 24, 35, 782);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.label19.Location = new System.Drawing.Point(62, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(210, 25);
            this.label19.TabIndex = 5;
            this.label19.Text = "Laporan Penjualan";
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(414, 234);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(75, 23);
            this.btnCetak.TabIndex = 15;
            this.btnCetak.Text = "CETAK";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
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
            // Laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 576);
            this.Controls.Add(this.panel1);
            this.Name = "Laporan";
            this.Text = "Laporan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btntampil;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DtSampai;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DtDari;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalPenjualan;
        private System.Windows.Forms.Button btnCetak;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}