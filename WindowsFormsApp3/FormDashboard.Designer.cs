namespace WindowsFormsApp3
{
    partial class FormDashboard
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblNamaSiswa = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblTotalJurnal = new System.Windows.Forms.Label();
            this.lblTitleCard1 = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblMenunggu = new System.Windows.Forms.Label();
            this.lblTitleCard2 = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblDisetujui = new System.Windows.Forms.Label();
            this.lblTitleCard3 = new System.Windows.Forms.Label();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblRevisi = new System.Windows.Forms.Label();
            this.lblTitleCard4 = new System.Windows.Forms.Label();
            this.btnTulisJurnal = new System.Windows.Forms.Button();
            this.btnLihatNilai = new System.Windows.Forms.Button();
            this.lblRiwayat = new System.Windows.Forms.Label();
            this.dgvRiwayat = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.panelHeader.Controls.Add(this.lblNamaSiswa);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(880, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblNamaSiswa
            // 
            this.lblNamaSiswa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamaSiswa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaSiswa.ForeColor = System.Drawing.Color.White;
            this.lblNamaSiswa.Location = new System.Drawing.Point(568, 24);
            this.lblNamaSiswa.Name = "lblNamaSiswa";
            this.lblNamaSiswa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNamaSiswa.Size = new System.Drawing.Size(280, 21);
            this.lblNamaSiswa.TabIndex = 1;
            this.lblNamaSiswa.Text = "Halo, Siswa";
            this.lblNamaSiswa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DASHBOARD SISWA PKL";
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlCard1.Controls.Add(this.lblTotalJurnal);
            this.pnlCard1.Controls.Add(this.lblTitleCard1);
            this.pnlCard1.Location = new System.Drawing.Point(30, 100);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(180, 100);
            this.pnlCard1.TabIndex = 1;
            // 
            // lblTotalJurnal
            // 
            this.lblTotalJurnal.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalJurnal.ForeColor = System.Drawing.Color.White;
            this.lblTotalJurnal.Location = new System.Drawing.Point(0, 35);
            this.lblTotalJurnal.Name = "lblTotalJurnal";
            this.lblTotalJurnal.Size = new System.Drawing.Size(180, 50);
            this.lblTotalJurnal.TabIndex = 1;
            this.lblTotalJurnal.Text = "0";
            this.lblTotalJurnal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleCard1
            // 
            this.lblTitleCard1.AutoSize = true;
            this.lblTitleCard1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCard1.ForeColor = System.Drawing.Color.White;
            this.lblTitleCard1.Location = new System.Drawing.Point(12, 12);
            this.lblTitleCard1.Name = "lblTitleCard1";
            this.lblTitleCard1.Size = new System.Drawing.Size(99, 17);
            this.lblTitleCard1.TabIndex = 0;
            this.lblTitleCard1.Text = "TOTAL JURNAL";
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlCard2.Controls.Add(this.lblMenunggu);
            this.pnlCard2.Controls.Add(this.lblTitleCard2);
            this.pnlCard2.Location = new System.Drawing.Point(240, 100);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(180, 100);
            this.pnlCard2.TabIndex = 2;
            // 
            // lblMenunggu
            // 
            this.lblMenunggu.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenunggu.ForeColor = System.Drawing.Color.White;
            this.lblMenunggu.Location = new System.Drawing.Point(0, 35);
            this.lblMenunggu.Name = "lblMenunggu";
            this.lblMenunggu.Size = new System.Drawing.Size(180, 50);
            this.lblMenunggu.TabIndex = 1;
            this.lblMenunggu.Text = "0";
            this.lblMenunggu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleCard2
            // 
            this.lblTitleCard2.AutoSize = true;
            this.lblTitleCard2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCard2.ForeColor = System.Drawing.Color.White;
            this.lblTitleCard2.Location = new System.Drawing.Point(12, 12);
            this.lblTitleCard2.Name = "lblTitleCard2";
            this.lblTitleCard2.Size = new System.Drawing.Size(83, 17);
            this.lblTitleCard2.TabIndex = 0;
            this.lblTitleCard2.Text = "MENUNGGU";
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlCard3.Controls.Add(this.lblDisetujui);
            this.pnlCard3.Controls.Add(this.lblTitleCard3);
            this.pnlCard3.Location = new System.Drawing.Point(450, 100);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(180, 100);
            this.pnlCard3.TabIndex = 3;
            // 
            // lblDisetujui
            // 
            this.lblDisetujui.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisetujui.ForeColor = System.Drawing.Color.White;
            this.lblDisetujui.Location = new System.Drawing.Point(0, 35);
            this.lblDisetujui.Name = "lblDisetujui";
            this.lblDisetujui.Size = new System.Drawing.Size(180, 50);
            this.lblDisetujui.TabIndex = 1;
            this.lblDisetujui.Text = "0";
            this.lblDisetujui.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleCard3
            // 
            this.lblTitleCard3.AutoSize = true;
            this.lblTitleCard3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCard3.ForeColor = System.Drawing.Color.White;
            this.lblTitleCard3.Location = new System.Drawing.Point(12, 12);
            this.lblTitleCard3.Name = "lblTitleCard3";
            this.lblTitleCard3.Size = new System.Drawing.Size(71, 17);
            this.lblTitleCard3.TabIndex = 0;
            this.lblTitleCard3.Text = "DISETUJUI";
            // 
            // pnlCard4
            // 
            this.pnlCard4.BackColor = System.Drawing.Color.Crimson;
            this.pnlCard4.Controls.Add(this.lblRevisi);
            this.pnlCard4.Controls.Add(this.lblTitleCard4);
            this.pnlCard4.Location = new System.Drawing.Point(660, 100);
            this.pnlCard4.Name = "pnlCard4";
            this.pnlCard4.Size = new System.Drawing.Size(180, 100);
            this.pnlCard4.TabIndex = 4;
            // 
            // lblRevisi
            // 
            this.lblRevisi.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevisi.ForeColor = System.Drawing.Color.White;
            this.lblRevisi.Location = new System.Drawing.Point(0, 35);
            this.lblRevisi.Name = "lblRevisi";
            this.lblRevisi.Size = new System.Drawing.Size(180, 50);
            this.lblRevisi.TabIndex = 1;
            this.lblRevisi.Text = "0";
            this.lblRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleCard4
            // 
            this.lblTitleCard4.AutoSize = true;
            this.lblTitleCard4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCard4.ForeColor = System.Drawing.Color.White;
            this.lblTitleCard4.Location = new System.Drawing.Point(12, 12);
            this.lblTitleCard4.Name = "lblTitleCard4";
            this.lblTitleCard4.Size = new System.Drawing.Size(95, 17);
            this.lblTitleCard4.TabIndex = 0;
            this.lblTitleCard4.Text = "PERLU REVISI";
            // 
            // btnTulisJurnal
            // 
            this.btnTulisJurnal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnTulisJurnal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTulisJurnal.FlatAppearance.BorderSize = 0;
            this.btnTulisJurnal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTulisJurnal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTulisJurnal.ForeColor = System.Drawing.Color.White;
            this.btnTulisJurnal.Location = new System.Drawing.Point(30, 225);
            this.btnTulisJurnal.Name = "btnTulisJurnal";
            this.btnTulisJurnal.Size = new System.Drawing.Size(180, 45);
            this.btnTulisJurnal.TabIndex = 5;
            this.btnTulisJurnal.Text = "📝 Tulis Jurnal Baru";
            this.btnTulisJurnal.UseVisualStyleBackColor = false;
            this.btnTulisJurnal.Click += new System.EventHandler(this.btnTulisJurnal_Click);
            // 
            // btnLihatNilai
            // 
            this.btnLihatNilai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLihatNilai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLihatNilai.FlatAppearance.BorderSize = 0;
            this.btnLihatNilai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLihatNilai.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLihatNilai.ForeColor = System.Drawing.Color.White;
            this.btnLihatNilai.Location = new System.Drawing.Point(240, 225);
            this.btnLihatNilai.Name = "btnLihatNilai";
            this.btnLihatNilai.Size = new System.Drawing.Size(180, 45);
            this.btnLihatNilai.TabIndex = 6;
            this.btnLihatNilai.Text = "🏆 Lihat Nilai PKL";
            this.btnLihatNilai.UseVisualStyleBackColor = false;
            this.btnLihatNilai.Click += new System.EventHandler(this.btnLihatNilai_Click);
            // 
            // lblRiwayat
            // 
            this.lblRiwayat.AutoSize = true;
            this.lblRiwayat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiwayat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRiwayat.Location = new System.Drawing.Point(26, 295);
            this.lblRiwayat.Name = "lblRiwayat";
            this.lblRiwayat.Size = new System.Drawing.Size(189, 21);
            this.lblRiwayat.TabIndex = 7;
            this.lblRiwayat.Text = "Riwayat Jurnal Terakhir";
            // 
            // dgvRiwayat
            // 
            this.dgvRiwayat.AllowUserToAddRows = false;
            this.dgvRiwayat.AllowUserToDeleteRows = false;
            this.dgvRiwayat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRiwayat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRiwayat.BackgroundColor = System.Drawing.Color.White;
            this.dgvRiwayat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRiwayat.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRiwayat.Location = new System.Drawing.Point(30, 330);
            this.dgvRiwayat.Name = "dgvRiwayat";
            this.dgvRiwayat.ReadOnly = true;
            this.dgvRiwayat.RowHeadersVisible = false;
            this.dgvRiwayat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRiwayat.Size = new System.Drawing.Size(810, 240);
            this.dgvRiwayat.TabIndex = 8;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.dgvRiwayat);
            this.Controls.Add(this.lblRiwayat);
            this.Controls.Add(this.btnLihatNilai);
            this.Controls.Add(this.btnTulisJurnal);
            this.Controls.Add(this.pnlCard4);
            this.Controls.Add(this.pnlCard3);
            this.Controls.Add(this.pnlCard2);
            this.Controls.Add(this.pnlCard1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Text = "Dashboard Siswa";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard3.PerformLayout();
            this.pnlCard4.ResumeLayout(false);
            this.pnlCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNamaSiswa;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblTitleCard1;
        private System.Windows.Forms.Label lblTotalJurnal;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblMenunggu;
        private System.Windows.Forms.Label lblTitleCard2;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblDisetujui;
        private System.Windows.Forms.Label lblTitleCard3;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblRevisi;
        private System.Windows.Forms.Label lblTitleCard4;
        private System.Windows.Forms.Button btnTulisJurnal;
        private System.Windows.Forms.Button btnLihatNilai;
        private System.Windows.Forms.Label lblRiwayat;
        private System.Windows.Forms.DataGridView dgvRiwayat;
    }
}