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

            Button btnCetak = new Button();
            btnCetak.Text = "🖨️ Cetak Data";
            btnCetak.Size = new Size(114, 31);
            btnCetak.Location = new Point(button2.Right + 10, button2.Top);
            btnCetak.Click += (s, ev) => LaporanHelper.CetakKeBrowser(dataGridView1, "DATA GURU PEMBIMBING PKL");
            this.Controls.Add(btnCetak);
            btnCetak.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTnm.Text))
            {
                MessageBox.Show("Nama guru tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO gurupembimbing (Nama, Telepon) VALUES (@Nama, @Telepon)", Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Nama", TXTnm.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telepon", TXTtlp.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Data guru berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersih();
                tampildata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data guru: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            label7.Text = "";
            button1.Visible = true;  // Tombol Simpan dimunculkan
            button4.Visible = false; // Tombol Update disembunyikan
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT Id_Gr, Nama, Telepon FROM gurupembimbing ORDER BY Id_Gr ASC", Classdb.koneksi))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["Id_Gr"].ToString();
                        string nama = reader["Nama"].ToString();
                        string telepon = reader["Telepon"].ToString();
                        dataGridView1.Rows.Add(id, nama, telepon);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Pilih guru yang ingin diubah terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                using (MySqlCommand cmd = new MySqlCommand("UPDATE gurupembimbing SET Nama = @Nama, Telepon = @Telepon WHERE Id_Gr = @IdGr", Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Nama", TXTnm.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telepon", TXTtlp.Text.Trim());
                    cmd.Parameters.AddWithValue("@IdGr", label7.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Data guru berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersih();
                tampildata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                using (MySqlCommand cmd = new MySqlCommand("SELECT Id_Gr, Nama, Telepon FROM gurupembimbing WHERE Nama LIKE @Cari ORDER BY Id_Gr ASC", Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Cari", "%" + lui + "%");
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string id = reader["Id_Gr"].ToString();
                            string nama = reader["Nama"].ToString();
                            string telepon = reader["Telepon"].ToString();
                            dataGridView1.Rows.Add(id, nama, telepon);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencari data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (indekskolom == 4)
            {
                DialogResult setuju1 = MessageBox.Show("Apakah yakin ingin menghapus data guru ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (setuju1 == DialogResult.Yes)
                {
                    try
                    {
                        if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM gurupembimbing WHERE Id_Gr = @IdGr", Classdb.koneksi))
                        {
                            cmd.Parameters.AddWithValue("@IdGr", idp);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Data guru berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersih();
                        tampildata();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menghapus data guru: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
                    }
                }
            }

            if (indekskolom == 3)
            {
                try
                {
                    if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT Id_Gr, Nama, Telepon FROM gurupembimbing WHERE Id_Gr = @IdGr", Classdb.koneksi))
                    {
                        cmd.Parameters.AddWithValue("@IdGr", idp);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                label7.Text = reader["Id_Gr"].ToString();
                                TXTnm.Text = reader["Nama"].ToString();
                                TXTtlp.Text = reader["Telepon"].ToString();
                                button1.Visible = false; // Sembunyikan tombol Simpan
                                button4.Visible = true;  // Munculkan tombol Update
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data guru: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
