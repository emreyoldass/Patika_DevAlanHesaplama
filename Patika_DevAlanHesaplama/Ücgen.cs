using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_DevAlanHesaplama
{
    class Ücgen
    {
        public void dikücgencevre()
        {
            //b+c+h(hipotenüs)
            Console.WriteLine("DİK ÜÇGEN ALAN HESAPLAMA");
            Console.WriteLine("Dik açının birinci komşu kenarının değerini giriniz: ");
            int dikkenar1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dik açının ikinci komşu kenarının değerini giriniz: ");
            int dikkenar2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hipotenüs değerini giriniz: ");
            int dikhipotenüs = int.Parse(Console.ReadLine());

            int sonuc = dikkenar1 + dikkenar2 + dikhipotenüs;
            Console.WriteLine($"Dik üçgenimiz çevresi : {sonuc}");
        }
        public void dikücgenalan()
        {
            // b * c / 2
            Console.WriteLine("DİK ÜÇGEN ALAN HESAPLAMA");
            Console.WriteLine("Dik üçgen alan hesaplama");
            Console.WriteLine("Dik açının birinci komşu kenarının değerini giriniz: ");
            int dikkenar1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dik açının ikinci komşu kenarının değerini giriniz: ");
            int dikkenar2 = int.Parse(Console.ReadLine());

            int sonuc = (dikkenar1 * dikkenar2) / 2;
            Console.WriteLine("Sonuc: " + sonuc);
        }
        
        public void ikizkenarcevre()
        {
            // a+b+c
            Console.WriteLine("İKİZKENAR ÇEVRE HESAPLAMA");
            Console.WriteLine("Birinci kenarı giriniz: ");
            int kenar1 = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci kenarı giriniz: ");
            int kenar2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ücünçü kenarı giriniz: ");
            int kenar3 = int.Parse(Console.ReadLine());

            int sonuc = kenar1 + kenar2 + kenar3;
            Console.WriteLine();

        }
        public void ikizkenaralan()
        {
            //bc * ah /2
            Console.WriteLine("İKİZKENAR ALAN HESAPLAMA");
            Console.WriteLine("İkizkenar üçgenin tabanını giriniz: ");
            int taban = int.Parse(Console.ReadLine());
            Console.WriteLine("İkizkenar üçgenin yüksekliğini giriniz: ");
            int yükseklik = int.Parse(Console.ReadLine());

            int sonuc = (taban * yükseklik) / 2;
            Console.WriteLine("Sonuc: "+ sonuc);
        }
        public  void eskenarücgencevre()
        {
            //3a
            Console.WriteLine("EŞKENAR ÜÇGEN ÇEVRE HESAPLAMA");
            Console.WriteLine("Kenarı giriniz: ");
            int kenar = int.Parse(Console.ReadLine());

            int sonuc = kenar * 3;
            Console.WriteLine("Sonuc: "+ sonuc);
        }
        public void eskenarücgenalan()
        {
            //(3kök/4).akaresi
            Console.WriteLine("EŞKENAR ÜÇGEN ALAN HESAPLAMA");
            Console.WriteLine("Kenarı giriniz: ");
            int deger = int.Parse(Console.ReadLine());
            int kök = (deger * deger);
            Console.WriteLine($"Sonuc: ({kök}* √3)/4 ");
        }
    }
}
