using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class FormDetailJurnal : Form
    {
        // Variabel untuk menangkap ID Laporan yang diklik
        private string idLaporan;

        // Constructor dimodifikasi agar bisa menerima ID
        public FormDetailJurnal(string id)
        {
            InitializeComponent();
            this.idLaporan = id;
            LoadDetail();
        }

        private void LoadDetail()
        {
            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed)
                    Classdb.koneksi.Open();

                string query = "SELECT * FROM jurnal_siswa WHERE id_laporan = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@id", idLaporan);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Isi Teks
                            DateTime tgl = Convert.ToDateTime(reader["tanggal"]);
                            lblTanggal.Text = tgl.ToString("dd MMMM yyyy");

                            txtKegiatanDetail.Text = reader["kegiatan"].ToString();
                            txtDeskripsiDetail.Text = reader["deskripsi"].ToString();

                            string status = reader["status"].ToString();
                            lblStatus.Text = status.ToUpper();

                            // Ganti warna status sesuai hasil
                            if (status == "Disetujui") lblStatus.ForeColor = Color.LimeGreen;
                            else if (status == "Ditolak" || status == "Revisi") lblStatus.ForeColor = Color.IndianRed;

                            string catatan = reader["catatan"].ToString();
                            txtCatatan.Text = string.IsNullOrWhiteSpace(catatan) ? "Belum ada catatan dari guru pembimbing." : catatan;

                            // Isi Foto (BLOB)
                            if (reader["gambar"] != DBNull.Value)
                            {
                                byte[] imgBytes = (byte[])reader["gambar"];
                                using (MemoryStream ms = new MemoryStream(imgBytes))
                                {
                                    picFotoDetail.Image = Image.FromStream(ms);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat detail jurnal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open)
                    Classdb.koneksi.Close();
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close(); // Tutup pop-up
        }
    }
}