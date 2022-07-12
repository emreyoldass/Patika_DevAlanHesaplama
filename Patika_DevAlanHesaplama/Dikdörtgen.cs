using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_DevAlanHesaplama
{
    class Dikdörtgen
    {
        public void dikdörtgencevre()
        {
            Console.WriteLine("DİKDÖRTGEN ÇEVRE HESAPLAMA");
            Console.WriteLine("Kısa kenarı giriniz: ");
            int kısakenar = int.Parse(Console.ReadLine());
            Console.WriteLine("Uzun kenarı giriniz: ");
            int uzunkenar = int.Parse(Console.ReadLine());

            int sonuc = 2 * (kısakenar + uzunkenar);
            Console.WriteLine("Sonuc: " + sonuc);

        }
        public void dikdörtgenalan()
        {
            Console.WriteLine("DiKDÖRTGEN ALAN HESAPLAMA");
            Console.WriteLine("Kısa kenarı giriniz: ");
            int kısakenar = int.Parse(Console.ReadLine());
            Console.WriteLine("Uzun kenarı giriniz: ");
            int uzunkenar = int.Parse(Console.ReadLine());

            int sonuc = kısakenar * uzunkenar;
            Console.WriteLine("Sonuc: "+sonuc);
        }
    }
}
