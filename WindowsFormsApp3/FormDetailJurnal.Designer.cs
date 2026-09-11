namespace WindowsFormsApp3
{
    partial class FormDetailJurnal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.btnTutup = new System.Windows.Forms.Button();
            this.lblCatatanGuru = new System.Windows.Forms.Label();
            this.txtCatatan = new System.Windows.Forms.TextBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.picFotoDetail = new System.Windows.Forms.PictureBox();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.txtDeskripsiDetail = new System.Windows.Forms.TextBox();
            this.lblKegiatan = new System.Windows.Forms.Label();
            this.txtKegiatanDetail = new System.Windows.Forms.TextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoDetail)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.White;
            this.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackground.Controls.Add(this.btnTutup);
            this.pnlBackground.Controls.Add(this.lblCatatanGuru);
            this.pnlBackground.Controls.Add(this.txtCatatan);
            this.pnlBackground.Controls.Add(this.lblFoto);
            this.pnlBackground.Controls.Add(this.picFotoDetail);
            this.pnlBackground.Controls.Add(this.lblDeskripsi);
            this.pnlBackground.Controls.Add(this.txtDeskripsiDetail);
            this.pnlBackground.Controls.Add(this.lblKegiatan);
            this.pnlBackground.Controls.Add(this.txtKegiatanDetail);
            this.pnlBackground.Controls.Add(this.pnlHeader);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(650, 550);
            this.pnlBackground.TabIndex = 0;
            // 
            // btnTutup
            // 
            this.btnTutup.BackColor = System.Drawing.Color.IndianRed;
            this.btnTutup.FlatAppearance.BorderSize = 0;
            this.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutup.ForeColor = System.Drawing.Color.White;
            this.btnTutup.Location = new System.Drawing.Point(250, 500);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(150, 35);
            this.btnTutup.TabIndex = 9;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = false;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // lblCatatanGuru
            // 
            this.lblCatatanGuru.AutoSize = true;
            this.lblCatatanGuru.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatatanGuru.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCatatanGuru.Location = new System.Drawing.Point(340, 310);
            this.lblCatatanGuru.Name = "lblCatatanGuru";
            this.lblCatatanGuru.Size = new System.Drawing.Size(117, 17);
            this.lblCatatanGuru.TabIndex = 8;
            this.lblCatatanGuru.Text = "Feedback / Revisi";
            // 
            // txtCatatan
            // 
            this.txtCatatan.BackColor = System.Drawing.Color.LightYellow;
            this.txtCatatan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatatan.Location = new System.Drawing.Point(340, 330);
            this.txtCatatan.Multiline = true;
            this.txtCatatan.Name = "txtCatatan";
            this.txtCatatan.ReadOnly = true;
            this.txtCatatan.Size = new System.Drawing.Size(280, 150);
            this.txtCatatan.TabIndex = 7;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(340, 80);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(116, 17);
            this.lblFoto.TabIndex = 6;
            this.lblFoto.Text = "Foto Dokumentasi";
            // 
            // picFotoDetail
            // 
            this.picFotoDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFotoDetail.Location = new System.Drawing.Point(340, 100);
            this.picFotoDetail.Name = "picFotoDetail";
            this.picFotoDetail.Size = new System.Drawing.Size(280, 200);
            this.picFotoDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotoDetail.TabIndex = 5;
            this.picFotoDetail.TabStop = false;
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeskripsi.Location = new System.Drawing.Point(20, 150);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(61, 17);
            this.lblDeskripsi.TabIndex = 4;
            this.lblDeskripsi.Text = "Deskripsi";
            // 
            // txtDeskripsiDetail
            // 
            this.txtDeskripsiDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtDeskripsiDetail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeskripsiDetail.Location = new System.Drawing.Point(20, 170);
            this.txtDeskripsiDetail.Multiline = true;
            this.txtDeskripsiDetail.Name = "txtDeskripsiDetail";
            this.txtDeskripsiDetail.ReadOnly = true;
            this.txtDeskripsiDetail.Size = new System.Drawing.Size(300, 310);
            this.txtDeskripsiDetail.TabIndex = 3;
            // 
            // lblKegiatan
            // 
            this.lblKegiatan.AutoSize = true;
            this.lblKegiatan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKegiatan.Location = new System.Drawing.Point(20, 80);
            this.lblKegiatan.Name = "lblKegiatan";
            this.lblKegiatan.Size = new System.Drawing.Size(59, 17);
            this.lblKegiatan.TabIndex = 2;
            this.lblKegiatan.Text = "Kegiatan";
            // 
            // txtKegiatanDetail
            // 
            this.txtKegiatanDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtKegiatanDetail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKegiatanDetail.Location = new System.Drawing.Point(20, 100);
            this.txtKegiatanDetail.Name = "txtKegiatanDetail";
            this.txtKegiatanDetail.ReadOnly = true;
            this.txtKegiatanDetail.Size = new System.Drawing.Size(300, 25);
            this.txtKegiatanDetail.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlHeader.Controls.Add(this.lblStatus);
            this.pnlHeader.Controls.Add(this.lblTanggal);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(648, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Gold;
            this.lblStatus.Location = new System.Drawing.Point(420, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(200, 21);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "STATUS";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.ForeColor = System.Drawing.Color.White;
            this.lblTanggal.Location = new System.Drawing.Point(20, 16);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(189, 25);
            this.lblTanggal.TabIndex = 0;
            this.lblTanggal.Text = "Tanggal Jurnal PKL";
            // 
            // FormDetailJurnal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 550);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetailJurnal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detail Jurnal";
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoDetail)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblKegiatan;
        private System.Windows.Forms.TextBox txtKegiatanDetail;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.TextBox txtDeskripsiDetail;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.PictureBox picFotoDetail;
        private System.Windows.Forms.TextBox txtCatatan;
        private System.Windows.Forms.Label lblCatatanGuru;
        private System.Windows.Forms.Button btnTutup;
    }
}