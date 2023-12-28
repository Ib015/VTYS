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
    public partial class guncelle : Form
    {
        public guncelle()
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

            string updateQuery = "UPDATE \"Kisi\" SET \"Ad\" = @Ad , \"Soyad\" = @Soyad WHERE \"KisiNo\" = @KisiNo";
            NpgsqlCommand kisicmd = new NpgsqlCommand(updateQuery,conn);

            kisicmd.Parameters.AddWithValue("@Ad", txtNewisim.Text);
            kisicmd.Parameters.AddWithValue("@Soyad", txtNewsoyisim.Text);
            kisicmd.Parameters.AddWithValue("@KisiNo", int.Parse(txtGuncelle.Text));

            kisicmd.ExecuteNonQuery();

            yenileListele();

            conn.Close();

        }

        private void guncelle_Load(object sender, EventArgs e)
        {
            yenileListele();
        }

        private void txtNewSoyisim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
