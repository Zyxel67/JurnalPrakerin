namespace WindowsFormsApp3
{
    partial class Form5
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
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblJudulTop = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnJurnal = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlKonten = new System.Windows.Forms.Panel();
            this.btnProfil = new System.Windows.Forms.Button();
            this.pnltop.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnltop.Controls.Add(this.lblUserInfo);
            this.pnltop.Controls.Add(this.lblJudulTop);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(200, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(784, 60);
            this.pnltop.TabIndex = 1;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.ForeColor = System.Drawing.Color.LightGray;
            this.lblUserInfo.Location = new System.Drawing.Point(620, 20);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(147, 19);
            this.lblUserInfo.TabIndex = 1;
            this.lblUserInfo.Text = "Status: Login sebagai...";
            // 
            // lblJudulTop
            // 
            this.lblJudulTop.AutoSize = true;
            this.lblJudulTop.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulTop.ForeColor = System.Drawing.Color.White;
            this.lblJudulTop.Location = new System.Drawing.Point(20, 15);
            this.lblJudulTop.Name = "lblJudulTop";
            this.lblJudulTop.Size = new System.Drawing.Size(311, 25);
            this.lblJudulTop.TabIndex = 0;
            this.lblJudulTop.Text = "SISTEM MONITORING PKL SISWA";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlSidebar.Controls.Add(this.btnProfil);
            this.pnlSidebar.Controls.Add(this.btnKeluar);
            this.pnlSidebar.Controls.Add(this.btnJurnal);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
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
            this.btnKeluar.TabIndex = 3;
            this.btnKeluar.Text = "Keluar (Logout)";
            this.btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnJurnal
            // 
            this.btnJurnal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJurnal.FlatAppearance.BorderSize = 0;
            this.btnJurnal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJurnal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJurnal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnJurnal.Location = new System.Drawing.Point(0, 130);
            this.btnJurnal.Name = "btnJurnal";
            this.btnJurnal.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnJurnal.Size = new System.Drawing.Size(200, 50);
            this.btnJurnal.TabIndex = 2;
            this.btnJurnal.Text = "Input Jurnal";
            this.btnJurnal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJurnal.UseVisualStyleBackColor = true;
            this.btnJurnal.Click += new System.EventHandler(this.btnJurnal_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboard.Location = new System.Drawing.Point(0, 80);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(200, 50);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(200, 80);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Sumar";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
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
            // btnProfil
            // 
            this.btnProfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProfil.Location = new System.Drawing.Point(0, 180);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProfil.Size = new System.Drawing.Size(200, 50);
            this.btnProfil.TabIndex = 4;
            this.btnProfil.Text = "Profil";
            this.btnProfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlKonten);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Siswa";
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
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnJurnal;
        private System.Windows.Forms.Label lblJudulTop;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnProfil;
    }
}