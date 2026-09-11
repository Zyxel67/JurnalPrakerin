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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 Gibran = new Form4();
            Gibran.Visible = true;
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtuser.Text) || string.IsNullOrWhiteSpace(txtpass.Text))
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

                // UPDATE PENTING: Tambahkan Ids, Id_Gr, dan Id_Pt ke dalam query
                string queryLogin = "SELECT UID, hak, Ids, Id_Gr, Id_Pt FROM user WHERE Nama = @Nama AND Password = SHA1(@Password)";

                using (MySqlCommand cmd = new MySqlCommand(queryLogin, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Nama", txtuser.Text);
                    cmd.Parameters.AddWithValue("@Password", txtpass.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            string idgibran = reader["UID"].ToString();
                            string cekhak = reader["hak"].ToString();

                            if (cekhak == "Admin")
                            {
                                MDIParent1 menuAdmin = new MDIParent1();
                                menuAdmin.sus = idgibran;
                                menuAdmin.Show();
                                this.Hide();
                            }
                            else if (cekhak == "Siswa")
                            {
                                Classdb.idUserLogin = reader["Ids"].ToString();

                                MessageBox.Show("Login Siswa Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form5 dashboard = new Form5();
                                dashboard.Show();
                                this.Hide();
                            }
                            else if (cekhak == "Guru")
                            {
                                // Guru pakai 'Id_Gr', bukan 'Ids'
                                Classdb.idUserLogin = reader["Id_Gr"].ToString();

                                MessageBox.Show("Login Guru Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form2 menuUser = new Form2();
                                menuUser.sas = idgibran;
                                menuUser.Show();
                                this.Hide();
                            }
                            else if (cekhak == "PT" || cekhak == "Pt")
                            {
                                // PT pakai 'Id_Pt'
                                Classdb.idUserLogin = reader["Id_Pt"].ToString();

                                MessageBox.Show("Login Perusahaan Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form2 menuUser = new Form2();
                                menuUser.sas = idgibran;
                                menuUser.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Hak akses tidak valid atau tidak dikenali!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username atau password salah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open)
                {
                    Classdb.koneksi.Close();
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form4 Gibran = new Form4();
            Gibran.Visible = true;
            this.Hide();
        }

        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
