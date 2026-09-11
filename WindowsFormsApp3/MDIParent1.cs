using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MDIParent1 : Form
    {
        // Variabel penampung yang dipanggil di Form1.cs
        public string sus;

        public MDIParent1()
        {
            InitializeComponent();
        }

        // --- FUNGSI MEMASUKKAN FORM KE DALAM pnlKonten ---
        private void TampilkanFormChild(Form Child)
        {
            // 1. Bersihkan form lama di dalam pnlKonten jika ada
            pnlKonten.Controls.Clear();

            // 2. Ubah sifat Form menjadi kontrol panel biasa
            Child.TopLevel = false;
            Child.FormBorderStyle = FormBorderStyle.None;
            Child.Dock = DockStyle.Fill; // Agar form memenuhi seluruh pnlKonten

            // 3. Masukkan ke panel & tampilkan
            pnlKonten.Controls.Add(Child);
            pnlKonten.Tag = Child;
            Child.Show();
        }

        // --- EVENT KLIK SIDEBAR TOMBOL ---
        private void btnDataSiswa_Click(object sender, EventArgs e)
        {
            TampilkanFormChild(new FormSiswa());
        }

        private void btnDataGuru_Click(object sender, EventArgs e)
        {
            TampilkanFormChild(new FormGuru());
        }

        private void btnDataPT_Click(object sender, EventArgs e)
        {
            TampilkanFormChild(new FormPT());
        }

        // --- EVENT KLIK STRIP MENU ATAS ---
        private void siswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TampilkanFormChild(new FormSiswa());
        }

        private void guruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TampilkanFormChild(new FormGuru());
        }

        private void ptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TampilkanFormChild(new FormPT());
        }

        // --- LOGOUT / UTILITY ---
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            DialogResult setuju = MessageBox.Show("Apakah yakin ingin keluar?", "Pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (setuju == DialogResult.Yes)
            {
                Form1 Gibran = new Form1();
                Gibran.Show();
                this.Hide();
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult setuju = MessageBox.Show("Yakin mau logout?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (setuju == DialogResult.Yes)
            {
                Classdb.idUserLogin = ""; // Hapus sesi
                Form1 login = new Form1(); // Ganti Form1 ke nama form login aslimu
                login.Show();
                this.Close();
            }
        }
    }
}