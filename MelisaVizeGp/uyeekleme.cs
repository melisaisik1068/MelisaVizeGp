using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MelisaVizeGp
{
    public partial class uyeekleme : Form
    {
        private List<Uye> uyeler;

        public uyeekleme()
        {
            InitializeComponent();
            uyeler = new List<Uye>();

            // Uyeler.json dosyasını okuma
            string dosyaYolu = "C:\\Users\\melis\\OneDrive\\Masaüstü\\uyeler.json";
            if (File.Exists(dosyaYolu))
            {
                string json = File.ReadAllText(dosyaYolu);
                uyeler = JsonConvert.DeserializeObject<List<Uye>>(json);
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

            Uye uye = new Uye()
            {
                Ad = textBox1.Text,
                Soyad = textBox2.Text,
                TcKimlikNo = textBox3.Text,
                CepTelefonu = textBox4.Text,
                KayitTarihi = textBox5.Text
            };

            uyeler.Add(uye);

            // Uyeler.json dosyasına yazma
            string json = JsonConvert.SerializeObject(uyeler);
            string dosyaYolu = "C:\\Users\\melis\\OneDrive\\Masaüstü\\uyeler.json";
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
