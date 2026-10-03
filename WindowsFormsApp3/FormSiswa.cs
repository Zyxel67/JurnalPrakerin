using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

            Button btnCetak = new Button();
            btnCetak.Text = "🖨️ Cetak Data";
            btnCetak.Size = new Size(114, 31);
            btnCetak.Location = new Point(button2.Right + 10, button2.Top);
            btnCetak.Click += (s, ev) => LaporanHelper.CetakKeBrowser(dataGridView1, "DATA SISWA PKL / PRAKERIN");
            this.Controls.Add(btnCetak);
            btnCetak.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTnm.Text))
            {
                MessageBox.Show("Nama siswa tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO siswa (Nama, Telepon, Jurusan, Kelas) VALUES (@Nama, @Telepon, @Jurusan, @Kelas)", Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Nama", TXTnm.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telepon", TXTtlp.Text.Trim());
                    cmd.Parameters.AddWithValue("@Jurusan", TXTjrs.Text.Trim());
                    cmd.Parameters.AddWithValue("@Kelas", TXTkls.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Data siswa berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersih();
                tampildata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data siswa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
            }
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
            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT Ids, Nama, Telepon, Jurusan, Kelas, Id_Pt, Id_Gr FROM siswa ORDER BY Ids ASC", Classdb.koneksi))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["Ids"].ToString();
                        string nama = reader["Nama"].ToString();
                        string telepon = reader["Telepon"].ToString();
                        string jurusan = reader["Jurusan"].ToString();
                        string kelas = reader["Kelas"].ToString();
                        string pt = reader["Id_Pt"] != DBNull.Value ? reader["Id_Pt"].ToString() : "-";
                        string gr = reader["Id_Gr"] != DBNull.Value ? reader["Id_Gr"].ToString() : "-";
                        dataGridView1.Rows.Add(id, nama, telepon, jurusan, kelas, pt, gr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data siswa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
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
            if (string.IsNullOrWhiteSpace(label7.Text))
            {
                MessageBox.Show("Pilih siswa yang ingin diubah terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                using (MySqlCommand cmd = new MySqlCommand("UPDATE siswa SET Nama = @Nama, Telepon = @Telepon, Jurusan = @Jurusan, Kelas = @Kelas WHERE Ids = @Ids", Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Nama", TXTnm.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telepon", TXTtlp.Text.Trim());
                    cmd.Parameters.AddWithValue("@Jurusan", TXTjrs.Text.Trim());
                    cmd.Parameters.AddWithValue("@Kelas", TXTkls.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ids", label7.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Data siswa berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersih();
                tampildata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui data siswa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
            }
        }

        public void caridata(string lui)
        {
            dataGridView1.Rows.Clear();
            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT Ids, Nama, Telepon, Jurusan, Kelas, Id_Pt, Id_Gr FROM siswa WHERE Nama LIKE @Cari ORDER BY Ids ASC", Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Cari", "%" + lui + "%");
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string id = reader["Ids"].ToString();
                            string nama = reader["Nama"].ToString();
                            string telepon = reader["Telepon"].ToString();
                            string jurusan = reader["Jurusan"].ToString();
                            string kelas = reader["Kelas"].ToString();
                            string pt = reader["Id_Pt"] != DBNull.Value ? reader["Id_Pt"].ToString() : "-";
                            string gr = reader["Id_Gr"] != DBNull.Value ? reader["Id_Gr"].ToString() : "-";
                            dataGridView1.Rows.Add(id, nama, telepon, jurusan, kelas, pt, gr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencari data siswa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
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
            string idp = dataGridView1.Rows[indeksbaris].Cells[0].Value?.ToString();

            if (indekskolom == 8)
            {
                DialogResult setuju1 = MessageBox.Show("Apakah yakin ingin menghapus data siswa ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (setuju1 == DialogResult.Yes)
                {
                    try
                    {
                        if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM siswa WHERE Ids = @Ids", Classdb.koneksi))
                        {
                            cmd.Parameters.AddWithValue("@Ids", idp);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Data siswa berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersih();
                        tampildata();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
                    }
                }
            }

            if (indekskolom == 7)
            {
                try
                {
                    if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT Ids, Nama, Telepon, Jurusan, Kelas FROM siswa WHERE Ids = @Ids", Classdb.koneksi))
                    {
                        cmd.Parameters.AddWithValue("@Ids", idp);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                label7.Text = reader["Ids"].ToString();
                                TXTnm.Text = reader["Nama"].ToString();
                                TXTjrs.Text = reader["Jurusan"].ToString();
                                TXTtlp.Text = reader["Telepon"].ToString();
                                TXTkls.Text = reader["Kelas"].ToString();
                                button1.Visible = false; // Sembunyikan tombol Simpan
                                button4.Visible = true;  // Munculkan tombol Update
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data siswa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
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
