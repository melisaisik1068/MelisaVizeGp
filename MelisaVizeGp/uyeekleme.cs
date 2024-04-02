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

            string dosyaYolu = "C:\\Users\\melis\\OneDrive\\Masaüstü\\uyeler.json";
            if (File.Exists(dosyaYolu))
            {
                string json = File.ReadAllText(dosyaYolu);
                uyeler = JsonConvert.DeserializeObject<List<Uye>>(json);
            }

            Listele();
        }

        private void Listele()
        {
            listBox1.Items.Clear();

            foreach (var uye in uyeler)
            {
                listBox1.Items.Add($"{uye.Ad} {uye.Soyad} - {uye.TcKimlikNo} - {uye.CepTelefonu} - {uye.KayitTarihi}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            string json = JsonConvert.SerializeObject(uyeler);
            string dosyaYolu = "C:\\Users\\melis\\OneDrive\\Masaüstü\\uyeler.json";
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                uyeler.RemoveAt(listBox1.SelectedIndex);

                string json = JsonConvert.SerializeObject(uyeler);
                string dosyaYolu = "C:\\Users\\melis\\OneDrive\\Masaüstü\\uyeler.json";
                File.WriteAllText(dosyaYolu, json, Encoding.UTF8);

                MessageBox.Show("Silme işlemi başarıyla tamamlandı!");
                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen bir üye seçiniz!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Uye secilenUye = uyeler[listBox1.SelectedIndex];

                textBox1.Text = secilenUye.Ad;
                textBox2.Text = secilenUye.Soyad;
                textBox3.Text = secilenUye.TcKimlikNo;
                textBox4.Text = secilenUye.CepTelefonu;
                textBox5.Text = secilenUye.KayitTarihi;

                uyeler.RemoveAt(listBox1.SelectedIndex);

                string json = JsonConvert.SerializeObject(uyeler);
                string dosyaYolu = "C:\\Users\\melis\\OneDrive\\Masaüstü\\uyeler.json";
                File.WriteAllText(dosyaYolu, json, Encoding.UTF8);

                MessageBox.Show("Düzenleme moduna geçtiniz.
