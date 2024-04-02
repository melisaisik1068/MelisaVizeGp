using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace emanetislemleri
{
    public partial class emanetislemleri : Form
    {
        private List<Emanet> emanetler;
        private string dosyaYolu = @"C:\Users\melis\OneDrive\Masaüstü\emanetislemleri.db";

        public emanetislemleri()
        {
            InitializeComponent();
            emanetler = new List<Emanet>();

            SQLiteConnection.CreateFile(dosyaYolu);
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
            using (SQLiteConnection baglanti = new SQLiteConnection($"Data Source={dosyaYolu};Version=3;"))
            {
                baglanti.Open();

                string sorgu = "INSERT INTO Emanetler (UyeAdiSoyadi, KitapBilgileri) VALUES (@UyeAdiSoyadi, @KitapBilgileri)";
                SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@UyeAdiSoyadi", emanet.UyeAdiSoyadi);
                komut.Parameters.AddWithValue("@KitapBilgileri", emanet.KitapBilgileri);

                komut.ExecuteNonQuery();

                baglanti.Close();
            }
        }

        private void Sil(string uyeAdiSoyadi, string kitapBilgileri)
        {
            using (SQLiteConnection baglanti = new SQLiteConnection($"Data Source={dosyaYolu};Version=3;"))
            {
                baglanti.Open();

                string sorgu = "DELETE FROM Emanetler WHERE UyeAdiSoyadi=@UyeAdiSoyadi AND KitapBilgileri=@KitapBilgileri";
                SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@UyeAdiSoyadi", uyeAdiSoyadi);
                komut.Parameters.AddWithValue("@KitapBilgileri", kitapBilgileri);

                komut.ExecuteNonQuery();

                baglanti.Close();
            }
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
