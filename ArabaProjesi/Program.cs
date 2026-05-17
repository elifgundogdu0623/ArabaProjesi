using System.Reflection.Emit;

namespace ArabaProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba mercedes = new Araba("sarı", 0, MotorTipi.Elektrikli);
            Araba bmw = new Araba("kırmızı", 50000, MotorTipi.Dizel);
            Araba audi = new Araba("beyaz"); 

            /* mercedes.Renk = "Sarı";
             mercedes.Model = "C180";


             bmw.Renk = "kırmızı";
             bmw.Model = "F30";


             audi.Renk = "beyaz";
             audi.Model = "A4";*/   // Constructor ile bu kısma gerek kalmadı parametre ile araba oluşurken bu özellikleri otomatik belirledik


           
            Console.Write("audi bilgileri: ");
            audi.BilgileriGoster();
            Console.Write("mercedes bilgileri: ");
            mercedes.BilgileriGoster();
            Console.Write("bmw bilgileri: ");
            bmw.BilgileriGoster();
            Console.WriteLine("-----------------------");



            bmw.ServisGereklimi();
            bmw.Sur(12000);
            bmw.ServisGereklimi();
            bmw.BakimYaptir();
            bmw.ServisGereklimi();

            bmw.Sur(5000);
            bmw.ServisGereklimi();

            bmw.Sur(2000);
            bmw.ServisGereklimi();
            bmw.Sur(3000);
            bmw.ServisGereklimi();

            Console.WriteLine(mercedes.FrenDiskDurumuGetir()); 
            audi.Sur(1000);
            audi.BilgileriGoster();

            ElektrikliAraba tesla = new ElektrikliAraba("sarı", 0);

            tesla.BilgileriGoster(); 
            tesla.SarjEt();





        }
    }
}
