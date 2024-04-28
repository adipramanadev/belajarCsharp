namespace mencarinilaimaksimum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            Double angkaTerbesar = 0.0;
            if (Double.Parse(txtAngkapertama.Text) >Double.Parse(txtAngkaKedua.Text))
            
                angkaTerbesar = Double.Parse(txtAngkapertama.Text);
            else
                angkaTerbesar = Double.Parse(txtAngkaKedua.Text);

            txtMaksimal.Text = "Angka Terbesar adalah" + angkaTerbesar;
            
        }
    }
}
