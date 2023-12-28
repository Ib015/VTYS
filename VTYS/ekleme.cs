using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS
{
    public partial class ekleme : Form
    {
        public ekleme()
        {
            InitializeComponent();
        }
        private void yenileListele()
        {
            NpgsqlConnection conn = new NpgsqlConnection("server=localHost;port=5432;Database=yedek;user ID=postgres;password=1234");

            string sorgu = "SELECT * FROM \"Kisi\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ekleme_Load(object sender, EventArgs e)
        {
            yenileListele();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("server=localHost;port=5432;Database=yedek;user ID=postgres;password=1234");

            conn.Open();

            NpgsqlCommand iletisimbilgilericmd = new NpgsqlCommand("INSERT  into \"iletisimBilgileri\" (\"TelNo\",\"email\", \"Adres\", \"KisiNo\") VALUES  (\"@TelNo\",\"@email\", \"@Adres\", \"@KisiNo\")", conn);
            iletisimbilgilericmd.Parameters.AddWithValue("@email", txtemail.Text);
            iletisimbilgilericmd.Parameters.AddWithValue("@TelNo", txtTelNo.Text);
            iletisimbilgilericmd.Parameters.AddWithValue("@Adres", txtadres.Text);
            iletisimbilgilericmd.Parameters.AddWithValue("@KisiNo", int.Parse(txtkisiNo.Text));
            iletisimbilgilericmd.ExecuteNonQuery();
            NpgsqlCommand kisicmd = new NpgsqlCommand("INSERT  into \"Kisi\" (\"TCNo\",\"Ad\",\"Soyad\",\"KisiTuru\") VALUES (\"@TCNo\",\"@Ad\",\"@Soyad\",\"@KisiTuru\")", conn);

            kisicmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            kisicmd.Parameters.AddWithValue("@TCNo", txttcno.Text);
            kisicmd.Parameters.AddWithValue("@Ad", txtAd.Text);
            kisicmd.Parameters.AddWithValue("@KisiTuru", txtKisiTuru.Text);
            kisicmd.ExecuteNonQuery();



            conn.Close();

            yenileListele();
        }
    }
}
