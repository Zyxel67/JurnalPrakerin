namespace WindowsFormsApp3
{
    partial class FormNilaiSiswa
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlGuru = new System.Windows.Forms.Panel();
            this.txtCatatanGuru = new System.Windows.Forms.TextBox();
            this.lblLabelCatatanGuru = new System.Windows.Forms.Label();
            this.lblNilaiGuru = new System.Windows.Forms.Label();
            this.lblTitleGuru = new System.Windows.Forms.Label();
            this.pnlPT = new System.Windows.Forms.Panel();
            this.txtCatatanPT = new System.Windows.Forms.TextBox();
            this.lblLabelCatatanPT = new System.Windows.Forms.Label();
            this.lblNilaiPT = new System.Windows.Forms.Label();
            this.lblTitlePT = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatusAkhir = new System.Windows.Forms.Label();
            this.lblTitleStatus = new System.Windows.Forms.Label();
            this.pnlGuru.SuspendLayout();
            this.pnlPT.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(257, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hasil Evaluasi & Nilai PKL";
            // 
            // pnlGuru
            // 
            this.pnlGuru.BackColor = System.Drawing.Color.White;
            this.pnlGuru.Controls.Add(this.txtCatatanGuru);
            this.pnlGuru.Controls.Add(this.lblLabelCatatanGuru);
            this.pnlGuru.Controls.Add(this.lblNilaiGuru);
            this.pnlGuru.Controls.Add(this.lblTitleGuru);
            this.pnlGuru.Location = new System.Drawing.Point(30, 70);
            this.pnlGuru.Name = "pnlGuru";
            this.pnlGuru.Size = new System.Drawing.Size(340, 280);
            this.pnlGuru.TabIndex = 1;
            // 
            // txtCatatanGuru
            // 
            this.txtCatatanGuru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtCatatanGuru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCatatanGuru.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatatanGuru.Location = new System.Drawing.Point(20, 150);
            this.txtCatatanGuru.Multiline = true;
            this.txtCatatanGuru.Name = "txtCatatanGuru";
            this.txtCatatanGuru.ReadOnly = true;
            this.txtCatatanGuru.Size = new System.Drawing.Size(300, 110);
            this.txtCatatanGuru.TabIndex = 3;
            this.txtCatatanGuru.Text = "Belum ada catatan.";
            // 
            // lblLabelCatatanGuru
            // 
            this.lblLabelCatatanGuru.AutoSize = true;
            this.lblLabelCatatanGuru.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelCatatanGuru.ForeColor = System.Drawing.Color.Gray;
            this.lblLabelCatatanGuru.Location = new System.Drawing.Point(16, 120);
            this.lblLabelCatatanGuru.Name = "lblLabelCatatanGuru";
            this.lblLabelCatatanGuru.Size = new System.Drawing.Size(116, 19);
            this.lblLabelCatatanGuru.TabIndex = 2;
            this.lblLabelCatatanGuru.Text = "Catatan Evaluasi :";
            // 
            // lblNilaiGuru
            // 
            this.lblNilaiGuru.AutoSize = true;
            this.lblNilaiGuru.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNilaiGuru.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNilaiGuru.Location = new System.Drawing.Point(120, 50);
            this.lblNilaiGuru.Name = "lblNilaiGuru";
            this.lblNilaiGuru.Size = new System.Drawing.Size(56, 65);
            this.lblNilaiGuru.TabIndex = 1;
            this.lblNilaiGuru.Text = "0";
            // 
            // lblTitleGuru
            // 
            this.lblTitleGuru.AutoSize = true;
            this.lblTitleGuru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTitleGuru.Location = new System.Drawing.Point(16, 16);
            this.lblTitleGuru.Name = "lblTitleGuru";
            this.lblTitleGuru.Size = new System.Drawing.Size(191, 21);
            this.lblTitleGuru.TabIndex = 0;
            this.lblTitleGuru.Text = "Nilai Guru Pembimbing";
            // 
            // pnlPT
            // 
            this.pnlPT.BackColor = System.Drawing.Color.White;
            this.pnlPT.Controls.Add(this.txtCatatanPT);
            this.pnlPT.Controls.Add(this.lblLabelCatatanPT);
            this.pnlPT.Controls.Add(this.lblNilaiPT);
            this.pnlPT.Controls.Add(this.lblTitlePT);
            this.pnlPT.Location = new System.Drawing.Point(390, 70);
            this.pnlPT.Name = "pnlPT";
            this.pnlPT.Size = new System.Drawing.Size(340, 280);
            this.pnlPT.TabIndex = 2;
            // 
            // txtCatatanPT
            // 
            this.txtCatatanPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtCatatanPT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCatatanPT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatatanPT.Location = new System.Drawing.Point(20, 150);
            this.txtCatatanPT.Multiline = true;
            this.txtCatatanPT.Name = "txtCatatanPT";
            this.txtCatatanPT.ReadOnly = true;
            this.txtCatatanPT.Size = new System.Drawing.Size(300, 110);
            this.txtCatatanPT.TabIndex = 4;
            this.txtCatatanPT.Text = "Belum ada catatan.";
            // 
            // lblLabelCatatanPT
            // 
            this.lblLabelCatatanPT.AutoSize = true;
            this.lblLabelCatatanPT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelCatatanPT.ForeColor = System.Drawing.Color.Gray;
            this.lblLabelCatatanPT.Location = new System.Drawing.Point(16, 120);
            this.lblLabelCatatanPT.Name = "lblLabelCatatanPT";
            this.lblLabelCatatanPT.Size = new System.Drawing.Size(116, 19);
            this.lblLabelCatatanPT.TabIndex = 3;
            this.lblLabelCatatanPT.Text = "Catatan Evaluasi :";
            // 
            // lblNilaiPT
            // 
            this.lblNilaiPT.AutoSize = true;
            this.lblNilaiPT.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNilaiPT.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblNilaiPT.Location = new System.Drawing.Point(120, 50);
            this.lblNilaiPT.Name = "lblNilaiPT";
            this.lblNilaiPT.Size = new System.Drawing.Size(56, 65);
            this.lblNilaiPT.TabIndex = 2;
            this.lblNilaiPT.Text = "0";
            // 
            // lblTitlePT
            // 
            this.lblTitlePT.AutoSize = true;
            this.lblTitlePT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTitlePT.Location = new System.Drawing.Point(16, 16);
            this.lblTitlePT.Name = "lblTitlePT";
            this.lblTitlePT.Size = new System.Drawing.Size(176, 21);
            this.lblTitlePT.TabIndex = 1;
            this.lblTitlePT.Text = "Nilai Dari Tempat PKL";
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlStatus.Controls.Add(this.lblStatusAkhir);
            this.pnlStatus.Controls.Add(this.lblTitleStatus);
            this.pnlStatus.Location = new System.Drawing.Point(30, 370);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(700, 100);
            this.pnlStatus.TabIndex = 3;
            // 
            // lblStatusAkhir
            // 
            this.lblStatusAkhir.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusAkhir.ForeColor = System.Drawing.Color.Gold;
            this.lblStatusAkhir.Location = new System.Drawing.Point(0, 45);
            this.lblStatusAkhir.Name = "lblStatusAkhir";
            this.lblStatusAkhir.Size = new System.Drawing.Size(700, 40);
            this.lblStatusAkhir.TabIndex = 1;
            this.lblStatusAkhir.Text = "MENUNGGU PENILAIAN";
            this.lblStatusAkhir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleStatus
            // 
            this.lblTitleStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleStatus.ForeColor = System.Drawing.Color.White;
            this.lblTitleStatus.Location = new System.Drawing.Point(0, 15);
            this.lblTitleStatus.Name = "lblTitleStatus";
            this.lblTitleStatus.Size = new System.Drawing.Size(700, 21);
            this.lblTitleStatus.TabIndex = 0;
            this.lblTitleStatus.Text = "STATUS KELULUSAN PKL";
            this.lblTitleStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormNilaiSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlPT);
            this.Controls.Add(this.pnlGuru);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNilaiSiswa";
            this.Text = "Nilai PKL";
            this.Load += new System.EventHandler(this.FormNilaiSiswa_Load);
            this.pnlGuru.ResumeLayout(false);
            this.pnlGuru.PerformLayout();
            this.pnlPT.ResumeLayout(false);
            this.pnlPT.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlGuru;
        private System.Windows.Forms.Label lblTitleGuru;
        private System.Windows.Forms.Label lblNilaiGuru;
        private System.Windows.Forms.TextBox txtCatatanGuru;
        private System.Windows.Forms.Label lblLabelCatatanGuru;
        private System.Windows.Forms.Panel pnlPT;
        private System.Windows.Forms.TextBox txtCatatanPT;
        private System.Windows.Forms.Label lblLabelCatatanPT;
        private System.Windows.Forms.Label lblNilaiPT;
        private System.Windows.Forms.Label lblTitlePT;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatusAkhir;
        private System.Windows.Forms.Label lblTitleStatus;
    }
}