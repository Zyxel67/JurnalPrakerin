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
    public partial class FormPT : Form
    {
        public FormPT()
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
            String nip = TXTalamat.Text;
            String nm = TXTnm.Text;
            String tlp = TXTtlp.Text;
            String pmb = TXTpembimbing.Text;
            Classdb.crud($"INSERT INTO perusahaan VALUES(null, '{nm}','{nip}', '{tlp}', '{pmb}')");
            bersih();
            bersih();
            tampildata();
        }

        private void bersih()
        {
            TXTtlp.Text = "";
            TXTnm.Text = "";
            TXTalamat.Text = "";
            label7.Text = ""; // Jangan lupa bersihkan juga label ID-nya

            // Mengatur tombol
            button1.Visible = true;  // Tombol Simpan dimunculkan
            button4.Visible = false; // Tombol Update disembunyikan
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            Classdb.crud("SELECT * FROM perusahaan");
            foreach (DataRow baris in Classdb.ds.Tables[0].Rows)
            {
                string id = "" + baris["Id_Pt"];
                string nama = "" + baris["Nama"];
                string alamat = "" + baris["Alamat"];
                string hak = "" + baris["Telepon"];
                string pmb = "" + baris["Nama_Pembimbing"];
                dataGridView1.Rows.Add(id, nama, alamat, hak, pmb);
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
            String al = TXTalamat.Text;
            String nm = TXTnm.Text;
            String tlp = TXTtlp.Text;
            String pmb = TXTpembimbing.Text;
            Classdb.crud($"UPDATE perusahaan SET Nama = '{nm}', Alamat = '{al}', Telepon = '{tlp}', Nama_Pembimbing = '{pmb}'  where Id_Pt = '{label7.Text}' ");
            bersih();
            tampildata();
        }

        public void caridata(string lui)
        {
            dataGridView1.Rows.Clear();
            Classdb.crud($"select * from perusahaan where nama like '%{lui}%'");
            foreach (DataRow baris in Classdb.ds.Tables[0].Rows)
            {
                string id = "" + baris["Id_Pt"];
                string nip = "" + baris["Nama"];
                string nama = "" + baris["Alamat"];
                string alamat = "" + baris["Telepon"];
                string pmb = "" + baris["Nama_Pembimbing"];
                dataGridView1.Rows.Add(id, nip, nama, alamat, pmb);
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

            if (indekskolom == 6)
            {
                DialogResult setuju1 = MessageBox.Show("Apakah yakin?", "Pemeberithauan", MessageBoxButtons.YesNo);

                if (setuju1 == DialogResult.Yes)
                {
                    Classdb.crud($"DELETE FROM perusahaan WHERE perusahaan.Id_Pt = '{idp}'");
                    tampildata();
                }
            }


            if (indekskolom == 5)
            {
                DialogResult setuju1 = MessageBox.Show("Apakah yakin?", "Pemeberithauan", MessageBoxButtons.YesNo);
                if (setuju1 == DialogResult.Yes)
                {
                    Classdb.crud($"select * from perusahaan where Id_Pt = '{idp}'");
                    foreach (DataRow baris in Classdb.ds.Tables[0].Rows)
                    {
                        string id = "" + baris["Id_Pt"];
                        label7.Text = id;
                        string nama = "" + baris["Nama"];
                        TXTnm.Text = nama;
                        string alamat = "" + baris["Alamat"];
                        TXTalamat.Text = alamat;
                        string password = "" + baris["Telepon"];
                        TXTtlp.Text = password;
                        string pmb = "" + baris["Nama_Pembimbing"];
                        TXTpembimbing.Text = pmb;

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
