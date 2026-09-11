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
    public partial class Form3 : Form
    {
       public string identitas;
        string jenis;
        string id;
        public Form3()
        {

            InitializeComponent();
         
        }


        public string sus;

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Gibran = new Form1();
            Gibran.Visible = true;
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNamaPembimbing_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            long idPtOtomatis = 0;

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                if (Classdb.koneksi.State == ConnectionState.Closed)
                {
                    Classdb.koneksi.Open();
                }


                string cekQuery = "SELECT COUNT(*) FROM user WHERE Nama = @Nama";
                using (MySqlCommand cmdCek = new MySqlCommand(cekQuery, Classdb.koneksi))
                {

                    cmdCek.Parameters.AddWithValue("@Nama", textBox1.Text);


                    int cekbaris = Convert.ToInt32(cmdCek.ExecuteScalar());

                    if (cekbaris > 0)
                    {
                        MessageBox.Show("User Sudah Terdaftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Hentikan eksekusi jika user sudah ada
                    }
                }

                // 3. Jika belum terdaftar, proses Insert Data menggunakan Transaksi
                DialogResult setuju = MessageBox.Show("Apakah yakin ingin mendaftar?", "Pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (setuju == DialogResult.Yes)
                {
                    // Memulai fitur Transaksi agar insert 2 tabel aman
                    MySqlTransaction transaksi = Classdb.koneksi.BeginTransaction();

                    try
                    {
                        // ========================================================
                        // LANGKAH 1: INSERT KE TABEL PROFIL (SISWA/GURU/PT) DULU
                        // ========================================================
                        if (jenis == "Siswa")
                        {
                            // Siapkan wadah kosong (NULL) sebagai nilai bawaan (default)
                            object idGuruDipilih = DBNull.Value;
                            object idPtDipilih = DBNull.Value;

                            // Kalau ComboBox Guru dipilih (tidak kosong), potong dan ambil ID-nya
                            if (cmbGuru.SelectedIndex != -1)
                            {
                                idGuruDipilih = cmbGuru.SelectedItem.ToString().Split('-')[0].Trim();
                            }

                            // Kalau ComboBox PT dipilih (tidak kosong), potong dan ambil ID-nya
                            if (cmbPT.SelectedIndex != -1)
                            {
                                idPtDipilih = cmbPT.SelectedItem.ToString().Split('-')[0].Trim();
                            }

                            // Insert ke tabel siswa. Kalau combobox kosong, nilai @IdGr dan @IdPt akan jadi NULL
                            string queryProfil = "INSERT INTO siswa (Ids, Nama, Telepon, Id_Gr, Id_Pt) VALUES (@IdProfil, @Nama, @Telepon, @IdGr, @IdPt)";
                            using (MySqlCommand cmdProfil = new MySqlCommand(queryProfil, Classdb.koneksi, transaksi))
                            {
                                cmdProfil.Parameters.AddWithValue("@IdProfil", id); // Ini adalah NIS dari Form4
                                cmdProfil.Parameters.AddWithValue("@Nama", textBox1.Text);
                                cmdProfil.Parameters.AddWithValue("@Telepon", textBox4.Text);
                                cmdProfil.Parameters.AddWithValue("@IdGr", idGuruDipilih);
                                cmdProfil.Parameters.AddWithValue("@IdPt", idPtDipilih);
                                cmdProfil.ExecuteNonQuery();
                            }
                        }
                        else if (jenis == "Guru")
                        {
                            string queryProfil = "INSERT INTO gurupembimbing (Id_Gr, Nama, Telepon) VALUES (@IdProfil, @Nama, @Telepon)";
                            using (MySqlCommand cmdProfil = new MySqlCommand(queryProfil, Classdb.koneksi, transaksi))
                            {
                                cmdProfil.Parameters.AddWithValue("@IdProfil", id);
                                cmdProfil.Parameters.AddWithValue("@Nama", textBox1.Text);
                                cmdProfil.Parameters.AddWithValue("@Telepon", textBox4.Text);
                                cmdProfil.ExecuteNonQuery();
                            }
                        }
                        else if (jenis == "PT")
                        {
                            // Cukup Insert Nama saja, Id_Pt diurus otomatis oleh Auto Increment MySQL
                            string queryProfil = "INSERT INTO perusahaan (Nama, Telepon, Nama_Pembimbing) VALUES (@Nama, @Telepon, @NMP)";
                            using (MySqlCommand cmdProfil = new MySqlCommand(queryProfil, Classdb.koneksi, transaksi))
                            {
                                cmdProfil.Parameters.AddWithValue("@Nama", textBox1.Text);
                                cmdProfil.Parameters.AddWithValue("@Telepon", textBox4.Text);
                                cmdProfil.Parameters.AddWithValue("@NMP", txtNamaPembimbing.Text);
                                cmdProfil.ExecuteNonQuery();

                                // Mengambil ID Auto Increment yang baru saja terbuat
                                idPtOtomatis = cmdProfil.LastInsertedId;
                            }
                        }

                        // ========================================================
                        // LANGKAH 2: INSERT KE TABEL USER
                        // ========================================================
                        string insertUser = "INSERT INTO user (Nama, Password, Email, hak, Ids, Id_Gr, Id_Pt) " +
                                            "VALUES (@Nama, SHA1(@Password), @Email, @Hak, @Ids, @Id_Gr, @Id_Pt)";

                        using (MySqlCommand cmdUser = new MySqlCommand(insertUser, Classdb.koneksi, transaksi))
                        {
                            cmdUser.Parameters.AddWithValue("@Nama", textBox1.Text);
                            cmdUser.Parameters.AddWithValue("@Password", textBox2.Text);
                            cmdUser.Parameters.AddWithValue("@Email", textBox3.Text);
                            cmdUser.Parameters.AddWithValue("@Hak", jenis);

                            // Logika menempatkan ID yang benar dan mengosongkan (NULL) yang lainnya
                            if (jenis == "Siswa")
                            {
                                cmdUser.Parameters.AddWithValue("@Ids", id);
                                cmdUser.Parameters.AddWithValue("@Id_Gr", DBNull.Value);
                                cmdUser.Parameters.AddWithValue("@Id_Pt", DBNull.Value);
                            }
                            else if (jenis == "Guru")
                            {
                                cmdUser.Parameters.AddWithValue("@Ids", DBNull.Value);
                                cmdUser.Parameters.AddWithValue("@Id_Gr", id);
                                cmdUser.Parameters.AddWithValue("@Id_Pt", DBNull.Value);
                            }
                            else if (jenis == "PT")
                            {
                                cmdUser.Parameters.AddWithValue("@Ids", DBNull.Value);
                                cmdUser.Parameters.AddWithValue("@Id_Gr", DBNull.Value);
                                cmdUser.Parameters.AddWithValue("@Id_Pt", idPtOtomatis);
                            }
                            else
                            {
                                cmdUser.Parameters.AddWithValue("@Ids", DBNull.Value);
                                cmdUser.Parameters.AddWithValue("@Id_Gr", DBNull.Value);
                                cmdUser.Parameters.AddWithValue("@Id_Pt", DBNull.Value);
                            }

                            cmdUser.ExecuteNonQuery();
                        }

                        // ========================================================
                        // LANGKAH 3: SIMPAN PERMANEN JIKA SEMUA BERHASIL
                        // ========================================================
                        transaksi.Commit();

                        MessageBox.Show("Registrasi dan pembuatan profil berhasil!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form1 formLogin = new Form1();
                        formLogin.Visible = true;
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        // JIKA ADA ERROR DI SALAH SATU PROSES, BATALKAN SEMUANYA AGAR DATABASE AMAN
                        transaksi.Rollback();
                        MessageBox.Show("Registrasi gagal. Sistem membatalkan perubahan. Error: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            finally
            {
                // 4. Selalu tutup koneksi di blok finally agar tidak terjadi kebocoran memori (Memory Leak)
                if (Classdb.koneksi.State == ConnectionState.Open)
                {
                    Classdb.koneksi.Close();
                }
            }



        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Form1 Gibran = new Form1();
            Gibran.Visible = true;
            this.Hide();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(identitas))
            {
                MessageBox.Show("Terjadi kesalahan: Data identitas kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] data = identitas.Split('|');

            jenis = data[0];
            id = data[1];

            lblGuru.Visible = false;
            cmbGuru.Visible = false;
            lblPT.Visible = false;
            cmbPT.Visible = false;
            lblNamaPembimbing.Visible = false;
            txtNamaPembimbing.Visible = false;

            if (jenis == "Siswa")
            {

                lblGuru.Visible = true;
                cmbGuru.Visible = true;
                lblPT.Visible = true;
                cmbPT.Visible = true;
            }
            else if (jenis == "Guru")
            {

            }
            else if (jenis == "PT")
            {
                lblNamaPembimbing.Visible = true;
                txtNamaPembimbing.Visible = true;
            }


            try
            {
                Classdb.koneksi.Open();


                string queryGuru = "SELECT Id_Gr, Nama FROM gurupembimbing";
                MySqlCommand cmdGuru = new MySqlCommand(queryGuru, Classdb.koneksi);
                MySqlDataReader readerGuru = cmdGuru.ExecuteReader();
                while (readerGuru.Read())
                {
                    cmbGuru.Items.Add(readerGuru["Id_Gr"] + " - " + readerGuru["Nama"]);
                }
                readerGuru.Close();

                string queryPT = "SELECT Id_Pt, Nama FROM perusahaan";
                MySqlCommand cmdPt = new MySqlCommand(queryPT, Classdb.koneksi);
                MySqlDataReader readerPt = cmdPt.ExecuteReader();
                while (readerPt.Read())
                {
                    cmbPT.Items.Add(readerPt["Id_Pt"] + " - " + readerPt["Nama"]);
                }
                readerPt.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data dari database: " + ex.Message);
            }
            finally
            {

                if (Classdb.koneksi.State == ConnectionState.Open)
                {
                    Classdb.koneksi.Close();
                }
            }
        }
    }

    }

