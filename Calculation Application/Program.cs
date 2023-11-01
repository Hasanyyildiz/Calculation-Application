using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Üçgen Alanı Hesaplama");
            Console.WriteLine("2 - Dikdörtgen Alanı Hesaplama:");
            Console.WriteLine("3 - Dairenin Alanı");
            Console.WriteLine("4 - Asal Sayı mı?");
            Console.WriteLine("5 - Faktoriyel Hesaplama");
            Console.WriteLine("6 - Negatif mi Pozitif mi Hesaplama");
            Console.WriteLine("");
            Console.Write("Yapmak İstediğiniz İşlem: ");
            string hesaplama = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");
            switch (hesaplama)
            {

                case "1":
                    Fonksiyonlar ucgenAlan = new Fonksiyonlar();
                    Console.WriteLine("Üçgenin Alanını Hesaplama");
                    Console.WriteLine("");
                    Console.Write("1. Kenarı giriniz: ");
                    ucgenAlan.Edge1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2. Kenarı giriniz: ");
                    ucgenAlan.Edge2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("sonuç: {0}", ucgenAlan.CalculateArea());
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("");
                    Console.ReadKey();
                    break;

                case "2":

                    //Dikdörtgenin Alanı
                    Fonksiyonlar dikdörtgenAlan = new Fonksiyonlar();
                    Console.WriteLine("Dikdörtgenin Alanını Hesaplama");
                    Console.WriteLine("");
                    Console.Write("Kısa Kenarı Giriniz: ");
                    dikdörtgenAlan.shortEdge = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Uzun Kenarı Giriniz: ");
                    dikdörtgenAlan.longSide = Convert.ToDouble(Console.ReadLine());

                    if (dikdörtgenAlan.shortEdge > dikdörtgenAlan.longSide)
                    {
                        Console.WriteLine("Hatalı girdi");
                    }
                    else
                    {
                        Console.WriteLine("Sonuç : {0}", dikdörtgenAlan.CalculateRectangularArea());
                    }
                    Console.WriteLine("");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("");
                    Console.ReadKey();
                    break;

                case "3":
                    //Dairenin Alanı
                    Fonksiyonlar daireAlan = new Fonksiyonlar();
                    Console.WriteLine("Dairenin Alanını Hesaplama");
                    Console.WriteLine("");
                    Console.Write("Dairenin Yarı Çapını Giriniz: ");
                    daireAlan.radius = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Pi sayısını giriniz: ");
                    daireAlan.pi = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Sonuç: {0}", daireAlan.CircleArea());
                    Console.WriteLine("");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("");
                    Console.ReadKey();
                    break;

                case "4":
                    //Asal sayı mı?
                    Fonksiyonlar asalSayi = new Fonksiyonlar();
                    Console.WriteLine("Asal Sayı mı?");
                    Console.WriteLine("");
                    Console.Write("Sayınızı Giriniz: ");
                    asalSayi.number6 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(asalSayi.AsalSayiMi());
                    Console.WriteLine("");
                    Console.WriteLine("---------------------------------");

                    Console.WriteLine("");
                    Console.ReadKey();
                    break;

                case "5":
                    //Faktoriyel Hesaplama
                    Fonksiyonlar faktoriyel = new Fonksiyonlar();
                    Console.WriteLine("Faktoriyel Hesaplama");
                    Console.WriteLine("");
                    Console.Write("Sayınızı Giriniz: ");
                    faktoriyel.number7 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("sonuç: {0}", faktoriyel.FaktoryelHesapla());
                    Console.WriteLine("");
                    Console.WriteLine("---------------------------------");

                    Console.WriteLine("");
                    Console.ReadKey();
                    break;

                case "6":
                    //Negatif mi? Pozitif mi?

                    Fonksiyonlar pozitifNegatif = new Fonksiyonlar();
                    Console.WriteLine("Sayınız Pozitif Mi? Negatif Mi?");
                    Console.WriteLine("");
                    Console.Write("Sayınızı Giriniz: ");
                    pozitifNegatif.number7 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Sayınız {0}", pozitifNegatif.PozitifNegatif());
                    Console.WriteLine("");
                    Console.WriteLine("---------------------------------");

                    Console.WriteLine("");
                    Console.ReadKey();
                    break;
                default: Console.WriteLine("HATALI İŞLEM YAPTINIZ");
                    break;
            }
        }







    }
    }
