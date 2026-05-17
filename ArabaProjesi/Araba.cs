using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaProjesi
{
    public enum MotorTipi //enum =enumeration (sabit değerler kümesi) // motor tipi için sabit değerler tanımladık
    {
        Dizel,
        Benzin,
        hibrid,
        Elektrikli

    }

    public enum FrenDiskDurumu
    {
        IYI,
        ORTA,
        KOTU
    }

    internal class Araba  //tasarım 
    {
        public string Renk { get; set; } // property=özellik
        public string Model { get; set; }
        public int Km { get; private set; } 

        private bool ServisIsıgıYansinMi = false; // field
        private int servisKm = 10000; // field 
        public MotorTipi Motor { get; } 
        private static Random rnd = new Random(); 


        public Araba(string renk, int baslangicKm, MotorTipi motor)  // Constructor (yapıcı metot) ile araba oluşurken temel özellikleri belirledik 
        {
            Renk = renk;
            Km = baslangicKm;
            Motor = motor;
        }

        public Araba(string renk) // Constructor overloading (yapıcı metot aşırı yükleme) // eğer araba oluştururken km bilgisi vermek istemezsek, sadece renk bilgisi vererek de araba oluşturabiliriz
        {
            Renk = renk;
            Km = 0;
            Motor = MotorTipi.Benzin; 
        }

        public virtual void BilgileriGoster() //metot=method // virtual=bu metot, bu sınıfın alt sınıflarında override edilebilir 
        {
            Console.WriteLine("Renk: " + Renk + " Km: " + Km + " Motor: " + Motor);


        }

        public void Sur(int kacKm) //metot=method
        {

            if (kacKm <= 0)
            {
                Console.WriteLine("Geçersiz sürüş mesafesi"); 
                return; 
            }
            Km += kacKm;
            Console.WriteLine($"{kacKm} km sürdünüz. Toplam km: {Km}");

            if (Km >= servisKm) 
                ServisIsıgıYansinMi = true;

        }

        public void ServisGereklimi()
        {
            if (ServisIsıgıYansinMi == true)
                Console.WriteLine("Servis zamanı geldi. Lütfen servise götürün.");
            else
                Console.WriteLine("Servis zamanı gelmedi. Araba iyi durumda.");
        }

        public void BakimYaptir()
        {
            Console.WriteLine("Aracınızın servis bakımı yapılıyor...");
            ServisIsıgıYansinMi = false; 
            servisKm = Km + 10000; // bir sonraki servis için km'yi güncelliyoruz 
        }

        public FrenDiskDurumu FrenDiskDurumuGetir()
        {
            int deger = rnd.Next(0, 3); // 0, 1,2
            return (FrenDiskDurumu)deger;
        }
    }
}
