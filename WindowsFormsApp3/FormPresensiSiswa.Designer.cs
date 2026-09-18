namespace WindowsFormsApp3
{
    partial class FormPresensiSiswa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTopTitle = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCheckIn = new System.Windows.Forms.Panel();
            this.lblStatusVerifikasiHariIni = new System.Windows.Forms.Label();
            this.lblStatusVerifikasiTitle = new System.Windows.Forms.Label();
            this.lblInfoHariIni = new System.Windows.Forms.Label();
            this.btnKirimPresensi = new System.Windows.Forms.Button();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblPilihStatus = new System.Windows.Forms.Label();
            this.lblTanggalHariIni = new System.Windows.Forms.Label();
            this.lblBoxTitle = new System.Windows.Forms.Label();
            this.dgvRiwayatPresensi = new System.Windows.Forms.DataGridView();
            this.lblRiwayat = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlTopTitle.SuspendLayout();
            this.pnlCheckIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayatPresensi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopTitle
            // 
            this.pnlTopTitle.BackColor = System.Drawing.Color.White;
            this.pnlTopTitle.Controls.Add(this.lblSubTitle);
            this.pnlTopTitle.Controls.Add(this.lblTitle);
            this.pnlTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTopTitle.Name = "pnlTopTitle";
            this.pnlTopTitle.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.pnlTopTitle.Size = new System.Drawing.Size(784, 65);
            this.pnlTopTitle.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSubTitle.Location = new System.Drawing.Point(20, 36);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(374, 15);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Catat dan pantau status verifikasi kehadiran kerja harian Anda oleh PT.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Location = new System.Drawing.Point(18, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PRESENSI HARIAN PKL";
            // 
            // pnlCheckIn
            // 
            this.pnlCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCheckIn.BackColor = System.Drawing.Color.White;
            this.pnlCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCheckIn.Controls.Add(this.lblStatusVerifikasiHariIni);
            this.pnlCheckIn.Controls.Add(this.lblStatusVerifikasiTitle);
            this.pnlCheckIn.Controls.Add(this.lblInfoHariIni);
            this.pnlCheckIn.Controls.Add(this.btnKirimPresensi);
            this.pnlCheckIn.Controls.Add(this.txtKeterangan);
            this.pnlCheckIn.Controls.Add(this.lblKeterangan);
            this.pnlCheckIn.Controls.Add(this.cmbStatus);
            this.pnlCheckIn.Controls.Add(this.lblPilihStatus);
            this.pnlCheckIn.Controls.Add(this.lblTanggalHariIni);
            this.pnlCheckIn.Controls.Add(this.lblBoxTitle);
            this.pnlCheckIn.Location = new System.Drawing.Point(20, 80);
            this.pnlCheckIn.Name = "pnlCheckIn";
            this.pnlCheckIn.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCheckIn.Size = new System.Drawing.Size(290, 400);
            this.pnlCheckIn.TabIndex = 1;
            // 
            // lblStatusVerifikasiHariIni
            // 
            this.lblStatusVerifikasiHariIni.AutoSize = true;
            this.lblStatusVerifikasiHariIni.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblStatusVerifikasiHariIni.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblStatusVerifikasiHariIni.Location = new System.Drawing.Point(135, 290);
            this.lblStatusVerifikasiHariIni.Name = "lblStatusVerifikasiHariIni";
            this.lblStatusVerifikasiHariIni.Size = new System.Drawing.Size(95, 17);
            this.lblStatusVerifikasiHariIni.TabIndex = 9;
            this.lblStatusVerifikasiHariIni.Text = "Belum Absen";
            // 
            // lblStatusVerifikasiTitle
            // 
            this.lblStatusVerifikasiTitle.AutoSize = true;
            this.lblStatusVerifikasiTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatusVerifikasiTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblStatusVerifikasiTitle.Location = new System.Drawing.Point(15, 291);
            this.lblStatusVerifikasiTitle.Name = "lblStatusVerifikasiTitle";
            this.lblStatusVerifikasiTitle.Size = new System.Drawing.Size(117, 15);
            this.lblStatusVerifikasiTitle.TabIndex = 8;
            this.lblStatusVerifikasiTitle.Text = "Status Verifikasi PT:";
            // 
            // lblInfoHariIni
            // 
            this.lblInfoHariIni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.lblInfoHariIni.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblInfoHariIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblInfoHariIni.Location = new System.Drawing.Point(15, 315);
            this.lblInfoHariIni.Name = "lblInfoHariIni";
            this.lblInfoHariIni.Padding = new System.Windows.Forms.Padding(6);
            this.lblInfoHariIni.Size = new System.Drawing.Size(256, 68);
            this.lblInfoHariIni.TabIndex = 7;
            this.lblInfoHariIni.Text = "Belum ada presensi untuk hari ini.";
            // 
            // btnKirimPresensi
            // 
            this.btnKirimPresensi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnKirimPresensi.FlatAppearance.BorderSize = 0;
            this.btnKirimPresensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKirimPresensi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnKirimPresensi.ForeColor = System.Drawing.Color.White;
            this.btnKirimPresensi.Location = new System.Drawing.Point(15, 240);
            this.btnKirimPresensi.Name = "btnKirimPresensi";
            this.btnKirimPresensi.Size = new System.Drawing.Size(256, 36);
            this.btnKirimPresensi.TabIndex = 6;
            this.btnKirimPresensi.Text = "Kirim Presensi Sekarang";
            this.btnKirimPresensi.UseVisualStyleBackColor = false;
            this.btnKirimPresensi.Click += new System.EventHandler(this.btnKirimPresensi_Click);
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeterangan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKeterangan.Location = new System.Drawing.Point(15, 160);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKeterangan.Size = new System.Drawing.Size(256, 65);
            this.txtKeterangan.TabIndex = 5;
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblKeterangan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblKeterangan.Location = new System.Drawing.Point(12, 140);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(126, 15);
            this.lblKeterangan.TabIndex = 4;
            this.lblKeterangan.Text = "Keterangan (Opsional):";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Hadir",
            "Izin",
            "Sakit"});
            this.cmbStatus.Location = new System.Drawing.Point(15, 100);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(256, 25);
            this.cmbStatus.TabIndex = 3;
            // 
            // lblPilihStatus
            // 
            this.lblPilihStatus.AutoSize = true;
            this.lblPilihStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPilihStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblPilihStatus.Location = new System.Drawing.Point(12, 80);
            this.lblPilihStatus.Name = "lblPilihStatus";
            this.lblPilihStatus.Size = new System.Drawing.Size(100, 15);
            this.lblPilihStatus.TabIndex = 2;
            this.lblPilihStatus.Text = "Status Kehadiran:";
            // 
            // lblTanggalHariIni
            // 
            this.lblTanggalHariIni.AutoSize = true;
            this.lblTanggalHariIni.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTanggalHariIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTanggalHariIni.Location = new System.Drawing.Point(12, 45);
            this.lblTanggalHariIni.Name = "lblTanggalHariIni";
            this.lblTanggalHariIni.Size = new System.Drawing.Size(147, 17);
            this.lblTanggalHariIni.TabIndex = 1;
            this.lblTanggalHariIni.Text = "Tanggal: 18/09/2026";
            // 
            // lblBoxTitle
            // 
            this.lblBoxTitle.AutoSize = true;
            this.lblBoxTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBoxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblBoxTitle.Location = new System.Drawing.Point(12, 15);
            this.lblBoxTitle.Name = "lblBoxTitle";
            this.lblBoxTitle.Size = new System.Drawing.Size(155, 20);
            this.lblBoxTitle.TabIndex = 0;
            this.lblBoxTitle.Text = "Presensi Masuk Kerja";
            // 
            // dgvRiwayatPresensi
            // 
            this.dgvRiwayatPresensi.AllowUserToAddRows = false;
            this.dgvRiwayatPresensi.AllowUserToDeleteRows = false;
            this.dgvRiwayatPresensi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRiwayatPresensi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRiwayatPresensi.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRiwayatPresensi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRiwayatPresensi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRiwayatPresensi.Location = new System.Drawing.Point(325, 115);
            this.dgvRiwayatPresensi.MultiSelect = false;
            this.dgvRiwayatPresensi.Name = "dgvRiwayatPresensi";
            this.dgvRiwayatPresensi.ReadOnly = true;
            this.dgvRiwayatPresensi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRiwayatPresensi.Size = new System.Drawing.Size(439, 365);
            this.dgvRiwayatPresensi.TabIndex = 2;
            // 
            // lblRiwayat
            // 
            this.lblRiwayat.AutoSize = true;
            this.lblRiwayat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRiwayat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblRiwayat.Location = new System.Drawing.Point(325, 85);
            this.lblRiwayat.Name = "lblRiwayat";
            this.lblRiwayat.Size = new System.Drawing.Size(185, 20);
            this.lblRiwayat.TabIndex = 3;
            this.lblRiwayat.Text = "Riwayat Kehadiran Anda";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(674, 80);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 28);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Segarkan";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormPresensiSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblRiwayat);
            this.Controls.Add(this.dgvRiwayatPresensi);
            this.Controls.Add(this.pnlCheckIn);
            this.Controls.Add(this.pnlTopTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPresensiSiswa";
            this.Text = "Presensi Siswa";
            this.Load += new System.EventHandler(this.FormPresensiSiswa_Load);
            this.pnlTopTitle.ResumeLayout(false);
            this.pnlTopTitle.PerformLayout();
            this.pnlCheckIn.ResumeLayout(false);
            this.pnlCheckIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayatPresensi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlCheckIn;
        private System.Windows.Forms.Label lblBoxTitle;
        private System.Windows.Forms.Label lblTanggalHariIni;
        private System.Windows.Forms.Label lblPilihStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Button btnKirimPresensi;
        private System.Windows.Forms.Label lblStatusVerifikasiTitle;
        private System.Windows.Forms.Label lblStatusVerifikasiHariIni;
        private System.Windows.Forms.Label lblInfoHariIni;
        private System.Windows.Forms.DataGridView dgvRiwayatPresensi;
        private System.Windows.Forms.Label lblRiwayat;
        private System.Windows.Forms.Button btnRefresh;
    }
}

