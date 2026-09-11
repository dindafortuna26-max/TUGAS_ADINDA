namespace adindaa1
{
    partial class Kategori
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nomor = new System.Windows.Forms.Label();
            this.guna2BtnTampil = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BtnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BtnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TxtNamaKategori = new Guna.UI2.WinForms.Guna2TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(237)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.nomor);
            this.panel1.Controls.Add(this.guna2BtnTampil);
            this.panel1.Controls.Add(this.guna2BtnUpdate);
            this.panel1.Controls.Add(this.guna2BtnSimpan);
            this.panel1.Controls.Add(this.guna2TxtNamaKategori);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 688);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // nomor
            // 
            this.nomor.AutoSize = true;
            this.nomor.Location = new System.Drawing.Point(260, 110);
            this.nomor.Name = "nomor";
            this.nomor.Size = new System.Drawing.Size(36, 13);
            this.nomor.TabIndex = 25;
            this.nomor.Text = "nomor";
            this.nomor.Click += new System.EventHandler(this.nomor_Click);
            // 
            // guna2BtnTampil
            // 
            this.guna2BtnTampil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2BtnTampil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2BtnTampil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2BtnTampil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2BtnTampil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2BtnTampil.ForeColor = System.Drawing.Color.White;
            this.guna2BtnTampil.Location = new System.Drawing.Point(364, 169);
            this.guna2BtnTampil.Name = "guna2BtnTampil";
            this.guna2BtnTampil.Size = new System.Drawing.Size(118, 27);
            this.guna2BtnTampil.TabIndex = 24;
            this.guna2BtnTampil.Text = "TAMPIL";
            this.guna2BtnTampil.Click += new System.EventHandler(this.guna2BtnTampil_Click);
            // 
            // guna2BtnUpdate
            // 
            this.guna2BtnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2BtnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2BtnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2BtnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.guna2BtnUpdate.Location = new System.Drawing.Point(222, 169);
            this.guna2BtnUpdate.Name = "guna2BtnUpdate";
            this.guna2BtnUpdate.Size = new System.Drawing.Size(118, 27);
            this.guna2BtnUpdate.TabIndex = 23;
            this.guna2BtnUpdate.Text = "UPDATE";
            this.guna2BtnUpdate.Click += new System.EventHandler(this.guna2BtnUpdate_Click);
            // 
            // guna2BtnSimpan
            // 
            this.guna2BtnSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2BtnSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2BtnSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2BtnSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2BtnSimpan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2BtnSimpan.ForeColor = System.Drawing.Color.White;
            this.guna2BtnSimpan.Location = new System.Drawing.Point(70, 169);
            this.guna2BtnSimpan.Name = "guna2BtnSimpan";
            this.guna2BtnSimpan.Size = new System.Drawing.Size(118, 27);
            this.guna2BtnSimpan.TabIndex = 22;
            this.guna2BtnSimpan.Text = "SIMPAN";
            this.guna2BtnSimpan.Click += new System.EventHandler(this.guna2BtnSimpan_Click);
            // 
            // guna2TxtNamaKategori
            // 
            this.guna2TxtNamaKategori.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TxtNamaKategori.DefaultText = "";
            this.guna2TxtNamaKategori.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TxtNamaKategori.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TxtNamaKategori.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtNamaKategori.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtNamaKategori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtNamaKategori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TxtNamaKategori.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtNamaKategori.Location = new System.Drawing.Point(67, 101);
            this.guna2TxtNamaKategori.Name = "guna2TxtNamaKategori";
            this.guna2TxtNamaKategori.PlaceholderText = "";
            this.guna2TxtNamaKategori.SelectedText = "";
            this.guna2TxtNamaKategori.Size = new System.Drawing.Size(134, 36);
            this.guna2TxtNamaKategori.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.label19.Location = new System.Drawing.Point(51, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(150, 25);
            this.label19.TabIndex = 5;
            this.label19.Text = " Data Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nama Kategori";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1187, 371);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Kategori";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama Kategori";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            // 
            // Kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 688);
            this.Controls.Add(this.panel1);
            this.Name = "Kategori";
            this.Text = "Kategori";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TxtNamaKategori;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2BtnTampil;
        private Guna.UI2.WinForms.Guna2Button guna2BtnUpdate;
        private Guna.UI2.WinForms.Guna2Button guna2BtnSimpan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.Label nomor;
    }
}