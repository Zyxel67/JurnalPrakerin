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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string jenis = cmbJenis.SelectedItem.ToString();

            if (jenis == "Siswa")
            {
                lblIdentitas.Text = "NIS";
                txtIdentitas.Enabled = true;
            }
            else if (jenis == "Guru")
            {
                lblIdentitas.Text = "NIP";
                txtIdentitas.Enabled = true;
            }
            else if (jenis == "PT")
            {
                lblIdentitas.Text = "NIS / NIP";
                txtIdentitas.Clear();
                txtIdentitas.Enabled = false;
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            Form3 form2 = new Form3();

            form2.identitas = cmbJenis.Text + "|" + txtIdentitas.Text;

            form2.Show();
            this.Hide();
        }

        private void cmbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string jenis = cmbJenis.SelectedItem.ToString();

            if (jenis == "Siswa")
            {
                lblIdentitas.Text = "NIS";
                txtIdentitas.Enabled = true;
            }
            else if (jenis == "Guru")
            {
                lblIdentitas.Text = "NIP";
                txtIdentitas.Enabled = true;
            }
            else if (jenis == "PT")
            {
                lblIdentitas.Text = "NIS / NIP";
                txtIdentitas.Clear();
                txtIdentitas.Enabled = false;
            }
        }
    }
}
