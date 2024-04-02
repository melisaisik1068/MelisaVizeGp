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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MelisaVizeGp
{
    public partial class kitapekleme : Form
    {
        private List<Kitap> kitaplar;

        public kitapekleme()
        {
            InitializeComponent();
            kitaplar = new List<Kitap>();

            string dosyaYolu = "C:\\Users\\melis\\OneDrive\\Masaüstü\\kitaplar.json";
            if (File.Exists(dosyaYolu))
            {
                string json = File.ReadAllText(dosyaYolu);
                kitaplar = JsonConvert.DeserializeObject<List<Kitap>>(json);
            }

            Listele();
        }

        private void Listele()
        {
            
            listBox1.Items.Clear();

            foreach (var kitap in kitaplar)
            {
                listBox1.Items.Add($"{kitap.Ad} - {kitap.Yazar} - {kitap.Yayinevi} - {kitap.Tur} - {kitap.DemirbasNumarasi}");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
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

          
            string json = JsonConvert.SerializeObject(kitaplar);
            string dosyaYolu = "C:\\Users\\melis\\OneDrive\\Masaüstü\\kitaplar.json";
            File.WriteAllText(dosyaYolu, json, Encoding.UTF8);

            MessageBox.Show("Kayıt işlemi başarıyla tamamlandı!");
            Temizle();
            Listele(); 
        }

        private void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                kitaplar.RemoveAt(listBox1.SelectedIndex);

                
                string json = JsonConvert.SerializeObject(kitaplar);
                string dosyaYolu = "C:\\Users\\melis\\OneDrive\\Masaüstü\\kitaplar.json";
                File.WriteAllText(dosyaYolu, json, Encoding.UTF8);

                MessageBox.Show("Silme işlemi başarıyla tamamlandı!");
                Listele(); 
            }
            else
            {
                MessageBox.Show("Lütfen bir kitap seçiniz!");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Kitap secilenKitap = kitaplar[listBox1.SelectedIndex];

                
                textBox1.Text = secilenKitap.Ad;
                textBox2.Text = secilenKitap.Yazar;
                textBox3.Text = secilenKitap.Yayinevi;
                textBox4.Text = secilenKitap.Tur;
                textBox5.Text = secilenKitap.DemirbasNumarasi;

                
                kitaplar.RemoveAt(listBox1.SelectedIndex);

              
                string json = JsonConvert.SerializeObject(kitaplar);
                string dosyaYolu = "C:\\Users\\melis\\OneDrive\\Masaüstü\\kitaplar.json";
                File.WriteAllText(dosyaYolu, json, Encoding.UTF8);

                MessageBox.Show("Düzenleme moduna geçtiniz. Lütfen bilgileri güncelleyiniz ve Kaydet butonuna basınız.");
            }
            else
            {
                MessageBox.Show("Lütfen bir kitap seçiniz!");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text))
            {
                Kitap kitap = new Kitap()
                {
                    Ad = textBox1.Text,
                    Yazar = textBox2.Text,
                    Yayinevi = textBox3.Text,
                    Tur = textBox4.Text,
                    DemirbasNumarasi = textBox5.Text
                };

                kitaplar.Add(kitap);

                
                string json = JsonConvert.SerializeObject(kitaplar);
                string dosyaYolu = "C:\\Users\\melis\\OneDrive\\Masaüstü\\kitaplar.json";
                File.WriteAllText(dosyaYolu, json, Encoding.UTF8);

                MessageBox.Show("Güncelleme işlemi başarıyla tamamlandı!");
                Temizle();
                Listele(); 
            }
            else
            {
                MessageBox.Show("Lütfen tüm bilgileri giriniz!");
            }
        }
    }
}
