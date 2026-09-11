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
    public partial class Form5 : Form
    {
        public string sus;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult setuju = MessageBox.Show("Apakah yakin?", "Pemeberithauan", MessageBoxButtons.YesNo);

            if (setuju == DialogResult.Yes)
            {
                Form1 Gibran = new Form1();
                Gibran.Visible = true;
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sus);
        }

        // Method untuk memanggil form anak ke dalam pnlKonten
        private void BukaFormDiPanel(Form formAnak)
        {
            if (pnlKonten.Controls.Count > 0)
                pnlKonten.Controls.Clear();

            formAnak.TopLevel = false;
            formAnak.FormBorderStyle = FormBorderStyle.None;
            formAnak.Dock = DockStyle.Fill;

            pnlKonten.Controls.Add(formAnak);
            pnlKonten.Tag = formAnak;
            formAnak.BringToFront();
            formAnak.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Bersihkan layar atau panggil form profil/beranda di sini nanti
            pnlKonten.Controls.Clear();
        }

        private void btnJurnal_Click(object sender, EventArgs e)
        {
            // Memanggil Form6 masuk ke tengah layar (pnlKonten)!
            BukaFormDiPanel(new Form6());
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

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }
            
        private void btnProfil_Click(object sender, EventArgs e)
        {
            BukaFormDiPanel(new FormProfilSiswa());
        }
    }
}
