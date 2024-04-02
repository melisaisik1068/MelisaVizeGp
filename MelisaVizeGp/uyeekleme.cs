using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Data.SQLite;

namespace MelisaVizeGp
{
    public partial class uyeekleme : Form
    {
        private List<Uye> uyeler;
        private string dosyaYolu = "uyeler.db";

        public uyeekleme()
        {
            InitializeComponent();
            uyeler = new List<Uye>();

            SQLiteConnection.CreateFile(dosyaYolu);

            VeritabanindanUyeleriYukle();

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

        private void Button1_Click(object sender, EventArgs e)
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

            UyeVeritabaninaEkle(uye);

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

        private void VeritabanindanUyeleriYukle()
        {
            using (SQLiteConnection baglanti = new SQLiteConnection($"Data Source={dosyaYolu};Version=3;"))
            {
                baglanti.Open();

                string sorgu = "SELECT * FROM Uyeler";
                SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
                SQLiteDataReader okuyucu = komut.ExecuteReader();

                while (okuyucu.Read())
                {
                    Uye uye = new Uye()
                    {
                        Ad = okuyucu["Ad"].ToString(),
                        Soyad = okuyucu["Soyad"].ToString(),
                        TcKimlikNo = okuyucu["TcKimlikNo"].ToString(),
                        CepTelefonu = okuyucu["CepTelefonu"].ToString(),
                        KayitTarihi = okuyucu["KayitTarihi"].ToString()
                    };
                    uyeler.Add(uye);
                }

                baglanti.Close();
            }
        }

        private void UyeVeritabaninaEkle(Uye uye)
        {
            using (SQLiteConnection baglanti = new SQLiteConnection($"Data Source={dosyaYolu};Version=3;"))
            {
                baglanti.Open();

                string sorgu = "INSERT INTO Uyeler (Ad, Soyad, TcKimlikNo, CepTelefonu, KayitTarihi) VALUES (@Ad, @Soyad, @TcKimlikNo, @CepTelefonu, @KayitTarihi)";
                SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Ad", uye.Ad);
                komut.Parameters.AddWithValue("@Soyad", uye.Soyad);
                komut.Parameters.AddWithValue("@TcKimlikNo", uye.TcKimlikNo);
                komut.Parameters.AddWithValue("@CepTelefonu", uye.CepTelefonu);
                komut.Parameters.AddWithValue("@KayitTarihi", uye.KayitTarihi);

                komut.ExecuteNonQuery();

                baglanti.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                uyeler.RemoveAt(listBox1.SelectedIndex);

                string json = JsonConvert.SerializeObject(uyeler);
                File.WriteAllText(dosyaYolu, json, Encoding.UTF8);

                MessageBox.Show("Silme işlemi başarıyla tamamlandı!");
                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen bir üye seçiniz!");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
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
                File.WriteAllText(dosyaYolu, json, Encoding.UTF8);

                MessageBox.Show("Düzenleme moduna geçtiniz.");
            }
        }
    }

    public class Uye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcKimlikNo { get; set; }
        public string CepTelefonu { get; set; }
        public string KayitTarihi { get; set; }
    }
}
