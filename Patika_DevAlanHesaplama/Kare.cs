using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_DevAlanHesaplama
{
    class Kare
    {
        public void kareçevre()
        {
            Console.WriteLine("KARE ÇEVRE HESAPLAMA");
            Console.WriteLine("Kenar uzunluğu giriniz: ");
            int kenar = int.Parse(Console.ReadLine());
            
            int sonuc = kenar * 4;
            Console.WriteLine("Sonuc: "+ sonuc);
        }
        public void karealan()
        {
            Console.WriteLine("KARE ALAN HESAPLAMA");
            Console.WriteLine("Kenarı giriniz: ");
            int kenar = int.Parse(Console.ReadLine());
           
            int sonuc = kenar * kenar;
            Console.WriteLine("Sonuc: " + sonuc);
        }
    }
}
