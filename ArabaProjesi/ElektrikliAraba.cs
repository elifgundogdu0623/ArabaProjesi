using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaProjesi
{
    internal class ElektrikliAraba : Araba 
    {
        public int BataryaYuzde { get; private set; }
        public ElektrikliAraba(string renk,int baslangicKm): base(renk, baslangicKm, MotorTipi.Elektrikli) 
        {
            BataryaYuzde = 100; 
        }

        public void SarjEt() 
        {
            BataryaYuzde = 100;
            Console.WriteLine("Araba şarj edildi. Batarya yüzdesi: " + BataryaYuzde + "%");
        }

        public override void BilgileriGoster()
        {
            Console.WriteLine("Renk: " + Renk + " Km: " + Km + " Motor: " + Motor +" Batarya Yüzdesi: " + BataryaYuzde + "%");
        }
    }
}
