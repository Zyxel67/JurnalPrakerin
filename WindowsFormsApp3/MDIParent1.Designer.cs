namespace WindowsFormsApp3
{
    partial class MDIParent1
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
            this.pnltop = new System.Windows.Forms.Panel();
            this.lblAdminInfo = new System.Windows.Forms.Label();
            this.lblJudulTop = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnDataPT = new System.Windows.Forms.Button();
            this.btnDataGuru = new System.Windows.Forms.Button();
            this.btnDataSiswa = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlKonten = new System.Windows.Forms.Panel();
            this.pnltop.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnltop.Controls.Add(this.lblAdminInfo);
            this.pnltop.Controls.Add(this.lblJudulTop);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(200, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(784, 60);
            this.pnltop.TabIndex = 1;
            // 
            // lblAdminInfo
            // 
            this.lblAdminInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdminInfo.AutoSize = true;
            this.lblAdminInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminInfo.ForeColor = System.Drawing.Color.LightGray;
            this.lblAdminInfo.Location = new System.Drawing.Point(620, 20);
            this.lblAdminInfo.Name = "lblAdminInfo";
            this.lblAdminInfo.Size = new System.Drawing.Size(134, 19);
            this.lblAdminInfo.TabIndex = 1;
            this.lblAdminInfo.Text = "Login as: Super User";
            // 
            // lblJudulTop
            // 
            this.lblJudulTop.AutoSize = true;
            this.lblJudulTop.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulTop.ForeColor = System.Drawing.Color.White;
            this.lblJudulTop.Location = new System.Drawing.Point(20, 15);
            this.lblJudulTop.Name = "lblJudulTop";
            this.lblJudulTop.Size = new System.Drawing.Size(212, 25);
            this.lblJudulTop.TabIndex = 0;
            this.lblJudulTop.Text = "ADMINISTRATOR HUB";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlSidebar.Controls.Add(this.btnKeluar);
            this.pnlSidebar.Controls.Add(this.btnDataPT);
            this.pnlSidebar.Controls.Add(this.btnDataGuru);
            this.pnlSidebar.Controls.Add(this.btnDataSiswa);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 561);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKeluar.FlatAppearance.BorderSize = 0;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.ForeColor = System.Drawing.Color.IndianRed;
            this.btnKeluar.Location = new System.Drawing.Point(0, 511);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnKeluar.Size = new System.Drawing.Size(200, 50);
            this.btnKeluar.TabIndex = 4;
            this.btnKeluar.Text = "Keluar (Logout)";
            this.btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluar.UseVisualStyleBackColor = true;
            // 
            // btnDataPT
            // 
            this.btnDataPT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDataPT.FlatAppearance.BorderSize = 0;
            this.btnDataPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataPT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataPT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDataPT.Location = new System.Drawing.Point(0, 180);
            this.btnDataPT.Name = "btnDataPT";
            this.btnDataPT.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDataPT.Size = new System.Drawing.Size(200, 50);
            this.btnDataPT.TabIndex = 3;
            this.btnDataPT.Text = "Data Perusahaan (PT)";
            this.btnDataPT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataPT.UseVisualStyleBackColor = true;
            this.btnDataPT.Click += new System.EventHandler(this.btnDataPT_Click);
            // 
            // btnDataGuru
            // 
            this.btnDataGuru.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDataGuru.FlatAppearance.BorderSize = 0;
            this.btnDataGuru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataGuru.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataGuru.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDataGuru.Location = new System.Drawing.Point(0, 130);
            this.btnDataGuru.Name = "btnDataGuru";
            this.btnDataGuru.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDataGuru.Size = new System.Drawing.Size(200, 50);
            this.btnDataGuru.TabIndex = 2;
            this.btnDataGuru.Text = "Data Guru";
            this.btnDataGuru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataGuru.UseVisualStyleBackColor = true;
            this.btnDataGuru.Click += new System.EventHandler(this.btnDataGuru_Click);
            // 
            // btnDataSiswa
            // 
            this.btnDataSiswa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDataSiswa.FlatAppearance.BorderSize = 0;
            this.btnDataSiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataSiswa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataSiswa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDataSiswa.Location = new System.Drawing.Point(0, 80);
            this.btnDataSiswa.Name = "btnDataSiswa";
            this.btnDataSiswa.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDataSiswa.Size = new System.Drawing.Size(200, 50);
            this.btnDataSiswa.TabIndex = 1;
            this.btnDataSiswa.Text = "Data Siswa";
            this.btnDataSiswa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataSiswa.UseVisualStyleBackColor = true;
            this.btnDataSiswa.Click += new System.EventHandler(this.btnDataSiswa_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(200, 80);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Sumar";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlKonten
            // 
            this.pnlKonten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlKonten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKonten.Location = new System.Drawing.Point(200, 60);
            this.pnlKonten.Name = "pnlKonten";
            this.pnlKonten.Size = new System.Drawing.Size(784, 501);
            this.pnlKonten.TabIndex = 2;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlKonten);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Panel pnlKonten;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnDataSiswa;
        private System.Windows.Forms.Button btnDataPT;
        private System.Windows.Forms.Button btnDataGuru;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label lblJudulTop;
        private System.Windows.Forms.Label lblAdminInfo;
    }
}