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
    public partial class FormGuru : Form
    {
        public FormGuru()
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
            
            String nm = TXTnm.Text;
            String tlp = TXTtlp.Text;
            Classdb.crud($"INSERT INTO gurupembimbing VALUES(null, '{nm}', '{tlp}')");
            bersih();
            bersih();
            tampildata();
        }

        private void bersih()
        {
            TXTtlp.Text = "";
            TXTnm.Text = "";
            label7.Text = "";
            button1.Visible = true;  // Tombol Simpan dimunculkan
            button4.Visible = false; // Tombol Update disembunyikan
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            Classdb.crud("SELECT * FROM gurupembimbing");
            foreach (DataRow baris in Classdb.ds.Tables[0].Rows)
            {
                string id = "" + baris["Id_Gr"];
                string alamat = "" + baris["Nama"];
                string hak = "" + baris["Telepon"];
                dataGridView1.Rows.Add(id, alamat, hak);
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
            String al = TXTnm.Text;
            String user = TXTtlp.Text;
            Classdb.crud($"UPDATE gurupembimbing SET Nama = '{al}', Telepon = '{user}' where Id_Gr = '{label7.Text}' ");
            bersih();
            tampildata();
        }

        public void caridata(string lui)
        {
            dataGridView1.Rows.Clear();
            Classdb.crud($"select * from gurupembimbing where nama like '%{lui}%'");
            foreach (DataRow baris in Classdb.ds.Tables[0].Rows)
            {
                string id = "" + baris["Id_Gr"];
                string nama = "" + baris["nama"];
                string alamat = "" + baris["Telepon"];
                dataGridView1.Rows.Add(id, nama, alamat);
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

            if (indekskolom == 4)
            {
                DialogResult setuju1 = MessageBox.Show("Apakah yakin?", "Pemeberithauan", MessageBoxButtons.YesNo);

                if (setuju1 == DialogResult.Yes)
                {
                    Classdb.crud($"DELETE FROM gurupembimbing WHERE gurupembimbing.Id_Gr = '{idp}'");
                    tampildata();
                }
            }


            if (indekskolom == 3)
            {
                DialogResult setuju1 = MessageBox.Show("Apakah yakin?", "Pemeberithauan", MessageBoxButtons.YesNo);
                if (setuju1 == DialogResult.Yes)
                {
                    Classdb.crud($"select * from gurupembimbing where Id_Gr = '{idp}'");
                    foreach (DataRow baris in Classdb.ds.Tables[0].Rows)
                    {
                        string id = "" + baris["Id_Gr"];
                        label7.Text = id;
                        string alamat = "" + baris["Nama"];
                        TXTnm.Text = alamat;
                        string password = "" + baris["Telepon"];
                        TXTtlp.Text = password;
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
    }
}
