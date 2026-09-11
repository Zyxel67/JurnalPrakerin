namespace WindowsFormsApp3
{
    partial class FormProfilSiswa
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
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblLabelPT = new System.Windows.Forms.Label();
            this.lblPT = new System.Windows.Forms.Label();
            this.lblLabelGuru = new System.Windows.Forms.Label();
            this.lblGuru = new System.Windows.Forms.Label();
            this.lblLabelTelepon = new System.Windows.Forms.Label();
            this.lblTelepon = new System.Windows.Forms.Label();
            this.lblLabelNama = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblLabelNIS = new System.Windows.Forms.Label();
            this.lblNIS = new System.Windows.Forms.Label();
            this.panelGaris = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Informasi Siswa";
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.lblSubtitle);
            this.pnlCard.Controls.Add(this.panelGaris);
            this.pnlCard.Controls.Add(this.lblLabelPT);
            this.pnlCard.Controls.Add(this.lblPT);
            this.pnlCard.Controls.Add(this.lblLabelGuru);
            this.pnlCard.Controls.Add(this.lblGuru);
            this.pnlCard.Controls.Add(this.lblLabelTelepon);
            this.pnlCard.Controls.Add(this.lblTelepon);
            this.pnlCard.Controls.Add(this.lblLabelNama);
            this.pnlCard.Controls.Add(this.lblNama);
            this.pnlCard.Controls.Add(this.lblLabelNIS);
            this.pnlCard.Controls.Add(this.lblNIS);
            this.pnlCard.Location = new System.Drawing.Point(35, 90);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(700, 350);
            this.pnlCard.TabIndex = 1;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSubtitle.Location = new System.Drawing.Point(30, 20);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(126, 21);
            this.lblSubtitle.TabIndex = 11;
            this.lblSubtitle.Text = "Data Diri & PKL";
            // 
            // panelGaris
            // 
            this.panelGaris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.panelGaris.Location = new System.Drawing.Point(30, 50);
            this.panelGaris.Name = "panelGaris";
            this.panelGaris.Size = new System.Drawing.Size(640, 2);
            this.panelGaris.TabIndex = 10;
            // 
            // lblLabelNIS
            // 
            this.lblLabelNIS.AutoSize = true;
            this.lblLabelNIS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelNIS.ForeColor = System.Drawing.Color.Gray;
            this.lblLabelNIS.Location = new System.Drawing.Point(30, 80);
            this.lblLabelNIS.Name = "lblLabelNIS";
            this.lblLabelNIS.Size = new System.Drawing.Size(30, 19);
            this.lblLabelNIS.TabIndex = 0;
            this.lblLabelNIS.Text = "NIS";
            // 
            // lblNIS
            // 
            this.lblNIS.AutoSize = true;
            this.lblNIS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblNIS.Location = new System.Drawing.Point(30, 100);
            this.lblNIS.Name = "lblNIS";
            this.lblNIS.Size = new System.Drawing.Size(22, 21);
            this.lblNIS.TabIndex = 1;
            this.lblNIS.Text = "-";
            // 
            // lblLabelNama
            // 
            this.lblLabelNama.AutoSize = true;
            this.lblLabelNama.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelNama.ForeColor = System.Drawing.Color.Gray;
            this.lblLabelNama.Location = new System.Drawing.Point(30, 140);
            this.lblLabelNama.Name = "lblLabelNama";
            this.lblLabelNama.Size = new System.Drawing.Size(100, 19);
            this.lblLabelNama.TabIndex = 2;
            this.lblLabelNama.Text = "Nama Lengkap";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblNama.Location = new System.Drawing.Point(30, 160);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(22, 21);
            this.lblNama.TabIndex = 3;
            this.lblNama.Text = "-";
            // 
            // lblLabelTelepon
            // 
            this.lblLabelTelepon.AutoSize = true;
            this.lblLabelTelepon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelTelepon.ForeColor = System.Drawing.Color.Gray;
            this.lblLabelTelepon.Location = new System.Drawing.Point(30, 200);
            this.lblLabelTelepon.Name = "lblLabelTelepon";
            this.lblLabelTelepon.Size = new System.Drawing.Size(55, 19);
            this.lblLabelTelepon.TabIndex = 4;
            this.lblLabelTelepon.Text = "Telepon";
            // 
            // lblTelepon
            // 
            this.lblTelepon.AutoSize = true;
            this.lblTelepon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelepon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTelepon.Location = new System.Drawing.Point(30, 220);
            this.lblTelepon.Name = "lblTelepon";
            this.lblTelepon.Size = new System.Drawing.Size(22, 21);
            this.lblTelepon.TabIndex = 5;
            this.lblTelepon.Text = "-";
            // 
            // lblLabelGuru
            // 
            this.lblLabelGuru.AutoSize = true;
            this.lblLabelGuru.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelGuru.ForeColor = System.Drawing.Color.Gray;
            this.lblLabelGuru.Location = new System.Drawing.Point(350, 80);
            this.lblLabelGuru.Name = "lblLabelGuru";
            this.lblLabelGuru.Size = new System.Drawing.Size(119, 19);
            this.lblLabelGuru.TabIndex = 6;
            this.lblLabelGuru.Text = "Guru Pembimbing";
            // 
            // lblGuru
            // 
            this.lblGuru.AutoSize = true;
            this.lblGuru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblGuru.Location = new System.Drawing.Point(350, 100);
            this.lblGuru.Name = "lblGuru";
            this.lblGuru.Size = new System.Drawing.Size(22, 21);
            this.lblGuru.TabIndex = 7;
            this.lblGuru.Text = "-";
            // 
            // lblLabelPT
            // 
            this.lblLabelPT.AutoSize = true;
            this.lblLabelPT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelPT.ForeColor = System.Drawing.Color.Gray;
            this.lblLabelPT.Location = new System.Drawing.Point(350, 140);
            this.lblLabelPT.Name = "lblLabelPT";
            this.lblLabelPT.Size = new System.Drawing.Size(124, 19);
            this.lblLabelPT.TabIndex = 8;
            this.lblLabelPT.Text = "Tempat PKL / Mitra";
            // 
            // lblPT
            // 
            this.lblPT.AutoSize = true;
            this.lblPT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPT.Location = new System.Drawing.Point(350, 160);
            this.lblPT.Name = "lblPT";
            this.lblPT.Size = new System.Drawing.Size(22, 21);
            this.lblPT.TabIndex = 9;
            this.lblPT.Text = "-";
            // 
            // FormProfilSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfilSiswa";
            this.Text = "Profil Siswa";
            this.Load += new System.EventHandler(this.FormProfilSiswa_Load);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblLabelNIS;
        private System.Windows.Forms.Label lblNIS;
        private System.Windows.Forms.Label lblLabelNama;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblLabelTelepon;
        private System.Windows.Forms.Label lblTelepon;
        private System.Windows.Forms.Label lblLabelGuru;
        private System.Windows.Forms.Label lblGuru;
        private System.Windows.Forms.Label lblLabelPT;
        private System.Windows.Forms.Label lblPT;
        private System.Windows.Forms.Panel panelGaris;
        private System.Windows.Forms.Label lblSubtitle;
    }
}