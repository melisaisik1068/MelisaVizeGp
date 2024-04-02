using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MelisaVizeGp
{
    public partial class kitapekleme : Form
    {
        private List<Kitap> kitaplar;
        private string dosyaYolu = "kitaplar.db";

        public kitapekleme()
        {
            InitializeComponent();
            kitaplar = new List<Kitap>();

            SQLiteConnection.CreateFile(dosyaYolu);

            VeritabanindanKitaplariYukle();

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

            KitapVeritabaninaEkle(kitap);

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

        private void VeritabanindanKitaplariYukle()
        {
            using (SQLiteConnection baglanti = new SQLiteConnection($"Data Source={dosyaYolu};Version=3;"))
            {
                baglanti.Open();

                string sorgu = "SELECT * FROM Kitaplar";
                SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
                SQLiteDataReader okuyucu = komut.ExecuteReader();

                while (okuyucu.Read())
                {
                    Kitap kitap = new Kitap()
                    {
                        Ad = okuyucu["Ad"].ToString(),
                        Yazar = okuyucu["Yazar"].ToString(),
                        Yayinevi = okuyucu["Yayinevi"].ToString(),
                        Tur = okuyucu["Tur"].ToString(),
                        DemirbasNumarasi = okuyucu["DemirbasNumarasi"].ToString()
                    };
                    kitaplar.Add(kitap);
                }

                baglanti.Close();
            }
        }

        private void KitapVeritabaninaEkle(Kitap kitap)
        {
            using (SQLiteConnection baglanti = new SQLiteConnection($"Data Source={dosyaYolu};Version=3;"))
            {
                baglanti.Open();

                string sorgu = "INSERT INTO Kitaplar (Ad, Yazar, Yayinevi, Tur, DemirbasNumarasi) VALUES (@Ad, @Yazar, @Yayinevi, @Tur, @DemirbasNumarasi)";
                SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Ad", kitap.Ad);
                komut.Parameters.AddWithValue("@Yazar", kitap.Yazar);
                komut.Parameters.AddWithValue("@Yayinevi", kitap.Yayinevi);
                komut.Parameters.AddWithValue("@Tur", kitap.Tur);
                komut.Parameters.AddWithValue("@DemirbasNumarasi", kitap.DemirbasNumarasi);

                komut.ExecuteNonQuery();

                baglanti.Close();
            }
        }
    }

    public class Kitap
    {
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public string Yayinevi { get; set; }
        public string Tur { get; set; }
        public string DemirbasNumarasi { get; set; }
    }
}
