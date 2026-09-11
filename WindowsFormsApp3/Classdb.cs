using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Classdb
    {

        public static MySqlConnection koneksi =
            new MySqlConnection("server=127.0.0.1; username='root'; password=''; database='project'");
        public static DataSet ds = new DataSet();
        public static MySqlDataAdapter da;
        public static MySqlCommand perintah;

        public static void crud(string kuerinya)
        {
            Console.WriteLine(kuerinya);
            ds.Tables.Clear();
            perintah = new MySqlCommand(kuerinya, koneksi);
            da = new MySqlDataAdapter(perintah);
            da.Fill(ds);
        }

        public static string idUserLogin = "";

        public static void untukform(Form Formluv, Panel PNLyou)
        {
            PNLyou.Controls.Clear();
            PNLyou.Controls.Add(Formluv);
            Formluv.FormBorderStyle = FormBorderStyle.None;
            Formluv.Dock = DockStyle.Fill;
            Formluv.Show();
        }

    }
}
