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
    public partial class silme : Form
    {
        public silme()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost;port=5432;Database=yedek;user ID=postgres;password=1234");

        private void yenileListele()
        {
            NpgsqlConnection conn = new NpgsqlConnection("server=localHost;port=5432;Database=yedek;user ID=postgres;password=1234");

            string sorgu = "SELECT * FROM \"Kisi\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("server=localHost;port=5432;Database=yedek;user ID=postgres;password=1234");

            conn.Open();

            NpgsqlCommand kisisilcmd = new NpgsqlCommand("delete from \"Kisi\" where \"KisiNo\" =" + int.Parse(txtKisiNoSil.Text), conn);
            kisisilcmd.Parameters.AddWithValue("@musteriid", int.Parse(txtKisiNoSil.Text));
            kisisilcmd.ExecuteNonQuery();

            conn.Close();
            yenileListele();

        }
  

        private void silme_Load_1(object sender, EventArgs e)
        {

            yenileListele();

        }
    }
}
