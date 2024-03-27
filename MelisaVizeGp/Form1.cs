using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelisaVizeGp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyeekleme uyeekleme = new uyeekleme();
            uyeekleme.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitapekleme kitapekleme = new kitapekleme();
            kitapekleme.Show();
        }
<<<<<<< HEAD
=======

        private void button3_Click(object sender, EventArgs e)
        {
            emanetislemleri emanetislemleri = new emanetislemleri();
            emanetislemleri.Show();
        }
>>>>>>> dosya ya yazma işlemi tamamlandı
    }
}
