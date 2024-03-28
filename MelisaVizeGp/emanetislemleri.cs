using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace emanetislemleri
{
    public partial class emanetislemleri : Form
    {
        public emanetislemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string uyeAdiSoyadi = textBox1.Text;
            string kitapBilgileri = textBox2.Text;

            
            Emanet emanet = new Emanet(uyeAdiSoyadi, kitapBilgileri);

           
            Kaydet(emanet);

           
            MessageBox.Show("Emanet işlemi başarıyla gerçekleşti!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string uyeAdiSoyadi = textBox1.Text;
            string kitapBilgileri = textBox2.Text;

            
            Sil(uyeAdiSoyadi, kitapBilgileri);

            MessageBox.Show("Emanet işlemi başarıyla silindi!");
        }

        private void Kaydet(Emanet emanet)
        {
         
            string dosyaYolu = @"C:\Users\melis\OneDrive\Masaüstü\emanetislemleri.json";

            
            List<Emanet> emanetler = new List<Emanet>();
            if (File.Exists(dosyaYolu))
            {
                emanetler = JsonConvert.DeserializeObject<List<Emanet>>(File.ReadAllText(dosyaYolu));
            }

          
            emanetler.Add(emanet);

          
            File.WriteAllText(dosyaYolu, JsonConvert.SerializeObject(emanetler));
        }

        private void Sil(string uyeAdiSoyadi, string kitapBilgileri)
        {
            
            string dosyaYolu = @"C:\Users\melis\OneDrive\Masaüstü\emanetislemleri.json";

         
            List<Emanet> emanetler = new List<Emanet>();
            if (File.Exists(dosyaYolu))
            {
                emanetler = JsonConvert.DeserializeObject<List<Emanet>>(File.ReadAllText(dosyaYolu));
            }

          
            Emanet silinecekEmanet = emanetler.Find(x => x.UyeAdiSoyadi == uyeAdiSoyadi && x.KitapBilgileri == kitapBilgileri);

           
            emanetler.Remove(silinecekEmanet);

            File.WriteAllText(dosyaYolu, JsonConvert.SerializeObject(emanetler));
        }
    }

    public class Emanet
    {
        public string UyeAdiSoyadi { get; set; }
        public string KitapBilgileri { get; set; }

        public Emanet(string uyeAdiSoyadi, string kitapBilgileri)
        {
            UyeAdiSoyadi = uyeAdiSoyadi;
            KitapBilgileri = kitapBilgileri;
        }
    }
}
