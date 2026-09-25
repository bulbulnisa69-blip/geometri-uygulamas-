namespace geometri_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kenarkare = Convert.ToInt32(textBox1.Text);
            int karealan = kenarkare * kenarkare;
            label6.Text = karealan.ToString();


            int uzunkenar= Convert.ToInt32(textBox3.Text);
            int kısakenar = Convert.ToInt32(textBox4.Text);
            int dıkdörtgenalan = uzunkenar * kısakenar;
            label7.Text = dıkdörtgenalan.ToString();


            int yarıcap =(int) Convert.ToDouble(textBox5.Text);
            double dairealan = Math.PI * (yarıcap * yarıcap);
            label8.Text=dairealan.ToString("F3");


        }
    }
}
