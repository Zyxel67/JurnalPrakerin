using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class FormProfilSiswa : Form
    {
        public FormProfilSiswa()
        {
            InitializeComponent();
        }

        private void FormProfilSiswa_Load(object sender, EventArgs e)
        {
            LoadDataProfil();
        }

        private void LoadDataProfil()
        {
            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed)
                    Classdb.koneksi.Open();

                string idSiswa = Classdb.idUserLogin;

                // Menggunakan LEFT JOIN untuk menarik nama Guru dan nama PT berdasarkan ID yang tersimpan di tabel Siswa
                string query = @"SELECT s.Ids, s.Nama AS NamaSiswa, s.Telepon, 
                                        IFNULL(g.Nama, 'Belum Ditentukan') AS NamaGuru, 
                                        IFNULL(p.Nama, 'Belum Ditentukan') AS NamaPT 
                                 FROM siswa s 
                                 LEFT JOIN gurupembimbing g ON s.Id_Gr = g.Id_Gr 
                                 LEFT JOIN perusahaan p ON s.Id_Pt = p.Id_Pt 
                                 WHERE s.Ids = @Ids";

                using (MySqlCommand cmd = new MySqlCommand(query, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Ids", idSiswa);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblNIS.Text = reader["Ids"].ToString();
                            lblNama.Text = reader["NamaSiswa"].ToString();
                            lblTelepon.Text = reader["Telepon"].ToString();
                            lblGuru.Text = reader["NamaGuru"].ToString();
                            lblPT.Text = reader["NamaPT"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Data profil siswa tidak ditemukan di database.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat profil: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open)
                    Classdb.koneksi.Close();
            }
        }
    }
}