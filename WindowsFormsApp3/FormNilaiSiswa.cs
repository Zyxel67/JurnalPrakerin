using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class FormNilaiSiswa : Form
    {
        public FormNilaiSiswa()
        {
            InitializeComponent();
        }

        public void LoadDataNilai()
        {
            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed)
                    Classdb.koneksi.Open();

                string idSiswa = Classdb.idUserLogin;

                string query = "SELECT * FROM nilai_pkl WHERE Ids = @Ids";
                using (MySqlCommand cmd = new MySqlCommand(query, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Ids", idSiswa);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Masukkan data ke Label dan TextBox
                            lblNilaiGuru.Text = reader["nilai_guru"].ToString();
                            txtCatatanGuru.Text = reader["catatan_guru"].ToString();

                            lblNilaiPT.Text = reader["nilai_pt"].ToString();
                            txtCatatanPT.Text = reader["catatan_pt"].ToString();

                            lblStatusAkhir.Text = reader["status_akhir"].ToString().ToUpper();

                            // Opsional: Ganti warna status jika LULUS
                            if (lblStatusAkhir.Text == "LULUS")
                            {
                                lblStatusAkhir.ForeColor = System.Drawing.Color.LimeGreen;
                            }
                            else if (lblStatusAkhir.Text == "TIDAK LULUS")
                            {
                                lblStatusAkhir.ForeColor = System.Drawing.Color.IndianRed;
                            }
                        }
                        else
                        {
                            // Jika data belum ada sama sekali di tabel
                            lblNilaiGuru.Text = "0";
                            txtCatatanGuru.Text = "Guru belum memberikan evaluasi.";
                            lblNilaiPT.Text = "0";
                            txtCatatanPT.Text = "PT belum memberikan evaluasi.";
                            lblStatusAkhir.Text = "MENUNGGU PENILAIAN";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data nilai: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open)
                    Classdb.koneksi.Close();
            }
        }

        private void FormNilaiSiswa_Load(object sender, EventArgs e)
        {
            LoadDataNilai();
        }
    }
}