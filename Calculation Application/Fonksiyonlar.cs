using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Fonksiyonlar
    {
        //Üçgenin Alanı
        public double edge1;
        public double edge2;

        public double Edge1
        {
            get
            {
                return edge1;
            }

            set
            {
                edge1 = value;
            }

        }

        public double Edge2
        {
            get
            {
                return edge2;
            }

            set
            {
                edge2 = value;
            }
        }

        public double CalculateArea()
        {
            return edge1 * edge2 / 2;
        }

        //Dikdörtgenin Alanı
        public double longSide;
        public double shortEdge;
        public double LongSide
        {
            get
            {
                return longSide;
            }
            set
            {
                longSide = value;
            }
        }

        public double ShortEdge
        {
            get
            {
                return shortEdge;
            }
            set
            {
                shortEdge = value;
            }
        }

        public double CalculateRectangularArea()
        {
            return longSide * shortEdge;
        }

        //Dairenin Alanı
        //public int area;
        public double radius;
        public double pi;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public double Pi
        {
            get
            {
                return pi;
            }
            set
            {
                pi = value;
            }
        }

        public double CircleArea()
        {
            return radius * radius * pi;
        }


        //Asal Sayı Kontrol
        public int number6;

        public int Number6
        {
            get
            {
                return number6;
            }
            set
            {
                number6 = value;
            }
        }


        public int AsalSayiMi()
        {
            
            int sayac = 0;
            for (int i = 1; i <= number6; i++)
            {
                if (number6 % i == 0)
                {
                    sayac++;
                }
            }
            

            if(sayac == 2)
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayıdır", number6);
            }
            else
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayı Değildir.", number6);
            }
            return sayac;
            
        }
        


        //Faktoriyel hesaplama

        public int number5;
        public int faktoryel = 1;

        public int Number5
        {
            get
            {
                return number5;
            }
            set
            {
                number5 = value;
            }
        }

        public int Faktoryel
        {
            get
            {
                return faktoryel;
            }
            set
            {
                faktoryel = value;
            }
        }

        public int FaktoryelHesapla()
        {
            
            int faktoriyel = 1;
            for (int i = 1; i <= number5; i++)
            {
                faktoriyel *= i;

            }
           // Console.WriteLine(sayi5 + "! = " + faktoriyel);

           return faktoriyel;
            
        }

        //Negatif mi? Pozitif mi?
        public double number7;

        public double Number7
        {
            get
            {
                return number7;
            }
            set
            {
                number7 = value;
            }
        }

        public double PozitifNegatif()
        {
            if (number7 > 0)
            {
                Console.WriteLine("Girilen sayı POZITIF");
            }
            else if (number7 < 0) 
            { 
                Console.WriteLine("Girilen sayı NEGATIF"); 
            }
            else if (number7 == 0)
            {
                Console.WriteLine("Girilen sayı NÖTR");
            }

            return number7;
        }






    }
}
