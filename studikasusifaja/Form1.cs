namespace studikasusifaja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variabel untuk menampung data 
            Double skor1 = 0.0;
            Double skor2 = 0.0;
            Double skor3 = 0.0;
            Double rata = 0.0;

            //konstanta  
            const Int16 JUM_SKOR = 3;
            const Double dbSkor_Tinggi = 95.0;

            //terapkan disini 
            skor1 = Double.Parse(txtSkor1.Text);
            skor2 = Double.Parse(txtSkor2.Text);
            skor3 = Double.Parse(txtSkor3.Text);

            //menghitung rata rata 
            rata = (skor1 + skor2 + skor3) / JUM_SKOR;
            //menampilkan rata rata 
            txtRata.Text = rata.ToString("n2");

            //jika skor tertinggi menampilkan pesan 
            if (rata > dbSkor_Tinggi)

                lblPesan.Text = "Selamat! Kerja Keras anda membuahkan Hasil";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSkor1.Text = "";
            txtSkor2.Text = "";
            txtSkor3.Text = "";
            txtRata.Text = "";
            lblPesan.Text = "";
        }
    }
}
