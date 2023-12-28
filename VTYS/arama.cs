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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace VTYS
{
    public partial class arama : Form
    {
        public arama()
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
        private void aramaListele()
        {
            NpgsqlConnection conn = new NpgsqlConnection("server=localHost;port=5432;Database=yedek;user ID=postgres;password=1234");

            string sorgu = "SELECT * FROM \"Kisi\" where \"KisiNo\" = " + txtKisiIDile.Text;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("server=localHost;port=5432;Database=yedek;user ID=postgres;password=1234");

            conn.Open();

            NpgsqlCommand kisicmd = new NpgsqlCommand("select * from \"Kisi\" WHERE \"KisiNo\" = " + txtKisiIDile.Text, conn);

            string cumle = "select * from Kisi where KisiNo like '%" + txtKisiIDile.Text + "%'";


            kisicmd.ExecuteNonQuery();

            conn.Close();

            aramaListele();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtKisiIDile_TextChanged(object sender, EventArgs e)
        {

        }

        private void arama_Load(object sender, EventArgs e)
        {
            yenileListele();
        }
    }
}
