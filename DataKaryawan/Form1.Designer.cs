using System;

namespace DataKaryawan
{
	partial class DataKaryawan
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnHapus = new System.Windows.Forms.Button();
			this.btnUbah = new System.Windows.Forms.Button();
			this.btnSimpan = new System.Windows.Forms.Button();
			this.txtTelepon = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtAlamat = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cboxJabat = new System.Windows.Forms.ComboBox();
			this.txtNama = new System.Windows.Forms.TextBox();
			this.txtNIk = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtCari = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnCari = new System.Windows.Forms.Button();
			this.dataTable = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataTable);
			this.groupBox1.Location = new System.Drawing.Point(2, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(797, 233);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Table Data Karyawan";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnHapus);
			this.groupBox2.Controls.Add(this.btnUbah);
			this.groupBox2.Controls.Add(this.btnSimpan);
			this.groupBox2.Controls.Add(this.txtTelepon);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtEmail);
			this.groupBox2.Controls.Add(this.txtAlamat);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.cboxJabat);
			this.groupBox2.Controls.Add(this.txtNama);
			this.groupBox2.Controls.Add(this.txtNIk);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(2, 240);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(448, 210);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Data Karyawan";
			// 
			// btnHapus
			// 
			this.btnHapus.Location = new System.Drawing.Point(286, 135);
			this.btnHapus.Name = "btnHapus";
			this.btnHapus.Size = new System.Drawing.Size(155, 23);
			this.btnHapus.TabIndex = 14;
			this.btnHapus.Text = "Hapus";
			this.btnHapus.UseVisualStyleBackColor = true;
			this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
			// 
			// btnUbah
			// 
			this.btnUbah.Location = new System.Drawing.Point(62, 175);
			this.btnUbah.Name = "btnUbah";
			this.btnUbah.Size = new System.Drawing.Size(155, 23);
			this.btnUbah.TabIndex = 13;
			this.btnUbah.Text = "Ubah";
			this.btnUbah.UseVisualStyleBackColor = true;
			this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
			// 
			// btnSimpan
			// 
			this.btnSimpan.Location = new System.Drawing.Point(62, 135);
			this.btnSimpan.Name = "btnSimpan";
			this.btnSimpan.Size = new System.Drawing.Size(155, 23);
			this.btnSimpan.TabIndex = 12;
			this.btnSimpan.Text = "Simpan";
			this.btnSimpan.UseVisualStyleBackColor = true;
			this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
			// 
			// txtTelepon
			// 
			this.txtTelepon.Location = new System.Drawing.Point(286, 98);
			this.txtTelepon.Name = "txtTelepon";
			this.txtTelepon.Size = new System.Drawing.Size(155, 20);
			this.txtTelepon.TabIndex = 11;
			this.txtTelepon.TextChanged += new System.EventHandler(this.txtTelepon_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(235, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Telepon";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(286, 58);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(155, 20);
			this.txtEmail.TabIndex = 9;
			this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
			// 
			// txtAlamat
			// 
			this.txtAlamat.Location = new System.Drawing.Point(286, 17);
			this.txtAlamat.Name = "txtAlamat";
			this.txtAlamat.Size = new System.Drawing.Size(155, 20);
			this.txtAlamat.TabIndex = 8;
			this.txtAlamat.TextChanged += new System.EventHandler(this.txtAlamat_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(235, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Email";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(235, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Alamat";
			// 
			// cboxJabat
			// 
			this.cboxJabat.FormattingEnabled = true;
			this.cboxJabat.Location = new System.Drawing.Point(62, 98);
			this.cboxJabat.Name = "cboxJabat";
			this.cboxJabat.Size = new System.Drawing.Size(155, 21);
			this.cboxJabat.TabIndex = 5;
			this.cboxJabat.SelectedIndexChanged += new System.EventHandler(this.cboxJabat_SelectedIndexChanged);
			// 
			// txtNama
			// 
			this.txtNama.Location = new System.Drawing.Point(62, 58);
			this.txtNama.Name = "txtNama";
			this.txtNama.Size = new System.Drawing.Size(155, 20);
			this.txtNama.TabIndex = 4;
			this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
			// 
			// txtNIk
			// 
			this.txtNIk.Location = new System.Drawing.Point(62, 17);
			this.txtNIk.Name = "txtNIk";
			this.txtNIk.Size = new System.Drawing.Size(155, 20);
			this.txtNIk.TabIndex = 3;
			this.txtNIk.TextChanged += new System.EventHandler(this.txtNIk_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Jabatan";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nama";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "NIK";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnCari);
			this.groupBox3.Controls.Add(this.txtCari);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Location = new System.Drawing.Point(565, 240);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(234, 210);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Pencarian";
			// 
			// txtCari
			// 
			this.txtCari.Location = new System.Drawing.Point(59, 17);
			this.txtCari.Name = "txtCari";
			this.txtCari.Size = new System.Drawing.Size(155, 20);
			this.txtCari.TabIndex = 13;
			this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(25, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Cari";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// btnCari
			// 
			this.btnCari.Location = new System.Drawing.Point(59, 51);
			this.btnCari.Name = "btnCari";
			this.btnCari.Size = new System.Drawing.Size(155, 23);
			this.btnCari.TabIndex = 15;
			this.btnCari.Text = "Cari";
			this.btnCari.UseVisualStyleBackColor = true;
			this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
			// 
			// dataTable
			// 
			this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataTable.Location = new System.Drawing.Point(14, 19);
			this.dataTable.Name = "dataTable";
			this.dataTable.Size = new System.Drawing.Size(763, 208);
			this.dataTable.TabIndex = 0;
			// 
			// DataKaryawan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "DataKaryawan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Data Karyaan";
			this.Load += new System.EventHandler(this.DataKaryawan_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
			this.ResumeLayout(false);

		}

		private void btnHapus_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNIk;
		private System.Windows.Forms.TextBox txtNama;
		private System.Windows.Forms.ComboBox cboxJabat;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtAlamat;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTelepon;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCari;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnSimpan;
		private System.Windows.Forms.Button btnUbah;
		private System.Windows.Forms.Button btnHapus;
		private System.Windows.Forms.Button btnCari;
		private System.Windows.Forms.DataGridView dataTable;
	}
}

