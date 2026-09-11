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
    public partial class FormSiswa : Form
    {
        public FormSiswa()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bersih();     // Ini otomatis menyembunyikan button4 dan memunculkan button1
            tampildata(); // Sekalian memuat isi DataGridView saat aplikasi pertama dibuka
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            String nip = TXTjrs.Text;
            String nm = TXTnm.Text;
            String tlp = TXTtlp.Text;
            String pmb = TXTkls.Text;
            Classdb.crud($"INSERT INTO siswa (Nama, Telepon, Jurusan, Kelas) VALUES ('{nm}', '{tlp}', '{nip}', '{pmb}')");
            bersih();
            bersih();
            tampildata();
        }

        private void bersih()
        {
            TXTtlp.Text = "";
            TXTnm.Text = "";
            TXTjrs.Text = "";
            TXTkls.Text = "";
            label7.Text = ""; // Jangan lupa bersihkan juga label ID-nya

            button1.Visible = true;  // Tombol Simpan dimunculkan
            button4.Visible = false; // Tombol Update disembunyikan
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            Classdb.crud("SELECT * FROM siswa");
            foreach (DataRow baris in Classdb.ds.Tables[0].Rows)
            {
                string id = "" + baris["Ids"];
                string nama = "" + baris["Nama"];
                string alamat = "" + baris["Telepon"];
                string hak = "" + baris["Jurusan"];
                string pmb = "" + baris["Kelas"];
                string pt = "" + baris["Id_Pt"];
                string gr = "" + baris["Id_Gr"];
                dataGridView1.Rows.Add(id, nama, alamat, hak, pmb, pt, gr);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String al = TXTjrs.Text;
            String nm = TXTnm.Text;
            String tlp = TXTtlp.Text;
            String pmb = TXTkls.Text;
            Classdb.crud($"UPDATE siswa SET Nama = '{nm}', Telepon = '{tlp}', Jurusan = '{al}', Kelas = '{pmb}'  where Ids = '{label7.Text}' ");
            bersih();
            tampildata();
        }

        public void caridata(string lui)
        {
            dataGridView1.Rows.Clear();
            Classdb.crud($"select * from siswa where nama like '%{lui}%'");
            foreach (DataRow baris in Classdb.ds.Tables[0].Rows)
            {
                string id = "" + baris["Ids"];
                string nip = "" + baris["Nama"];
                string nama = "" + baris["Telepon"];
                string alamat = "" + baris["Jurusan"];
                string pmb = "" + baris["Kelas"];
                string pt = "" + baris["Id_Pt"];
                string gr = "" + baris["Id_Gr"];
                dataGridView1.Rows.Add(id, nip, nama, alamat, pmb, pt, gr);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            caridata(textBox2.Text);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indeksbaris = e.RowIndex;
            int indekskolom = e.ColumnIndex;
            if (indeksbaris < 0) return;
            string idp = dataGridView1.Rows[indeksbaris].Cells[0].Value.ToString();

            if (indekskolom == 8)
            {
                DialogResult setuju1 = MessageBox.Show("Apakah yakin?", "Pemeberithauan", MessageBoxButtons.YesNo);

                if (setuju1 == DialogResult.Yes)
                {
                    Classdb.crud($"DELETE FROM siswa WHERE siswa.Ids = '{idp}'");
                    tampildata();
                }
            }


            if (indekskolom == 7)
            {
                DialogResult setuju1 = MessageBox.Show("Apakah yakin?", "Pemeberithauan", MessageBoxButtons.YesNo);
                if (setuju1 == DialogResult.Yes)
                {
                    Classdb.crud($"select * from siswa where Ids = '{idp}'");
                    foreach (DataRow baris in Classdb.ds.Tables[0].Rows)
                    {
                        string id = "" + baris["Ids"];
                        label7.Text = id;
                        string nama = "" + baris["Nama"];
                        TXTnm.Text = nama;
                        string alamat = "" + baris["Jurusan"];
                        TXTjrs.Text = alamat;
                        string password = "" + baris["Telepon"];
                        TXTtlp.Text = password;
                        string pmb = "" + baris["Kelas"];
                        TXTkls.Text = pmb;

                    }

                    button1.Visible = false; // Sembunyikan tombol Simpan
                    button4.Visible = true;  // Munculkan tombol Update
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TXTtlp_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTnm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TXTnip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
