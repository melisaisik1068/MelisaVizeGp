using Kitaplar;
using Newtonsoft.Json;
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
    public partial class kitapekleme : Form
    {
        private List<Kitap> kitaplar;
        public kitapekleme()
        {
            InitializeComponent();
            kitaplar = new List<Kitap>();

            // Kitaplar.json dosyasını okuma
            string dosyaYolu = "C:\\Users\\melis\\OneDrive\\Masaüstü\\kitaplar.json";
            if (File.Exists(dosyaYolu))
            {
                string json = File.ReadAllText(dosyaYolu);
                kitaplar = JsonConvert.DeserializeObject<List<Kitap>>(json);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kayıt işlemini gerçekleştirme
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri giriniz!");
                return;
            }

            Kitap kitap = new Kitap()
            {
                Ad = textBox1.Text,
                Yazar = textBox2.Text,
                Yayinevi = textBox3.Text,
                Tur = textBox4.Text,
                DemirbasNumarasi = textBox5.Text
            };

            kitaplar.Add(kitap);

            // Kitaplar.json dosyasına yazma
            string json = JsonConvert.SerializeObject(kitaplar);
            string dosyaYolu = "C:\\Users\\melis\\OneDrive\\Masaüstü\\kitaplar.json";
            File.WriteAllText(dosyaYolu, json, Encoding.UTF8);

            MessageBox.Show("Kayıt işlemi başarıyla tamamlandı!");
            Temizle();
        }
        private void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
