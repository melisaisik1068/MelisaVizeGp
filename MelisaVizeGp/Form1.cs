namespace MelisaVizeGp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void uyeeklemebutton_Click(object sender, EventArgs e)
        {
            uyeekleme form = new uyeekleme();
            uyeekleme.Show();
        }
        public void kitapeklemebutton_Click(object sender, EventArgs e)
        {
            kitapekleme form = new kitapekleme();
            kitapekleme.Show();
        }
        public void emanetislembutton_Click(object sender, EventArgs e)
        {
            emanetislemleri form = new emanetislemleri();
            emanetislemleri.Show();
        }


    }
}
