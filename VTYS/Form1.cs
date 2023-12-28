namespace VTYS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            arama form2 = new arama();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ekleme form3 = new ekleme();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            silme form4 = new silme();
            form4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            guncelle guncelle = new guncelle();
            guncelle.ShowDialog();
        }
    }
}