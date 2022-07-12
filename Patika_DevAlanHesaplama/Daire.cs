using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_DevAlanHesaplama
{
    class Daire
    {
        const double pi = 3.14;
        public void dairecevre()
        {
           
            Console.WriteLine("DAİRE ÇEVRE HESAPLAMA");
            Console.WriteLine("Dairenin yarıçapına giriniz: ");
            double yarıçap = int.Parse(Console.ReadLine());

            double sonuc = 2 * pi * yarıçap;
            Console.WriteLine("Sonuc: "+sonuc);

        }
        public void dairealan()
        {
            Console.WriteLine("DAİRE ALAN HESAPLAMA");
            Console.WriteLine("Dairenin yarıçapına giriniz: ");
            double yarıçap = int.Parse(Console.ReadLine());

            double sonuc = pi * yarıçap * yarıçap;
            Console.WriteLine("Sonuc: "+sonuc);
        }
    }
}
