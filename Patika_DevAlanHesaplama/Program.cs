using System;

namespace Patika_DevAlanHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *İşlem yapılmak istenen geometrik şekli kullanıcıdan alınmalı (Daire, Üçgen, Kare, Dikdörtgen vb..)
             *Seçilen şekle göre, kenar bilgilerin kullanıcıdan alınmalı
             *Hesaplanmak istenen boyutu kullanıcıdan alınmalı (Çevre, Alan, Hacim vb..)
             *Hesap sonucunu anlaşılır şekilde geri döndürmeli. 
             */
            Console.WriteLine("İşlem yapma istediğiniz geometrik şekli seçiniz :");

            Console.WriteLine("1-) Daire");
            Console.WriteLine("2-) Üçgen");
            Console.WriteLine("3-) Kare");
            Console.WriteLine("4-) Diktörgen");
            int sekilsecim = int.Parse(Console.ReadLine());
            Console.WriteLine("Hesaplamak istediğiniz boyutu giriniz: ");
            Console.WriteLine("1-) Alan");
            Console.WriteLine("2-) Çevre");
           
            int boyutsecim = int.Parse(Console.ReadLine());

            switch (sekilsecim)
            {
                //----Daire----
                case 1:
                    Daire _daire = new Daire();
                    switch (boyutsecim)
                    {
                        case 1:
                            _daire.dairealan();
                            break;
                        case 2:
                            _daire.dairecevre();
                            break;
                    }
                    break;

                //----Üçgen----
                case 2:
                    Ücgen _ücgen = new Ücgen();
                    switch (boyutsecim)
                    {
                        case 1:
                            Console.WriteLine("Üçgen çeşidini seçiniz: ");
                            Console.WriteLine("1-) Dik Üçgen");
                            Console.WriteLine("2-) İkizkenar Üçgen");
                            Console.WriteLine("3-) Eşkenar Üçgen");
                            int cesit = int.Parse(Console.ReadLine());
                            switch (cesit)
                            {
                                case 1:
                                    _ücgen.dikücgenalan();
                                    break;
                                case 2:
                                    _ücgen.ikizkenaralan();
                                    break;
                                case 3:
                                    _ücgen.eskenarücgenalan();
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Üçgen çeşidini seçiniz: ");
                            Console.WriteLine("1-) Dik Üçgen");
                            Console.WriteLine("2-) İkizkenar Üçgen");
                            Console.WriteLine("3-) Eşkenar Üçgen");
                            int cesit2 = int.Parse(Console.ReadLine());
                            switch (cesit2)
                            {
                                case 1:
                                    _ücgen.dikücgencevre();
                                    break;
                                case 2:
                                    _ücgen.ikizkenarcevre();
                                    break;
                                case 3:
                                    _ücgen.eskenarücgencevre();
                                    break;
                            }

                            break;
                    }
                    break;


                //----Kare----
                case 3:
                    Kare _kare = new Kare();
                    switch (boyutsecim)
                    {
                        case 1:
                            _kare.karealan();
                            break;
                        case 2:
                            _kare.kareçevre();
                            break;
                    }
                    break;
                //----Dikdörtgen----
                case 4:
                    Dikdörtgen _dikdörtgen = new Dikdörtgen();
                    switch (boyutsecim)
                    {
                        case 1:
                            _dikdörtgen.dikdörtgenalan();
                            break;
                        case 2:
                            _dikdörtgen.dikdörtgencevre();
                            break;
                    }
                    break;
            }
        }
    }
}
