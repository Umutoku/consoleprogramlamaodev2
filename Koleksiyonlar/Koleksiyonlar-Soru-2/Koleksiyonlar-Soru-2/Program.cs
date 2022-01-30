using System;
using System.Collections.Generic;
using System.Linq;

namespace soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizi = new int[20];
            for (int i = 0; i < sayiDizi.Length; i++)
            {
                System.Console.WriteLine("{0}. Sayıyı Girin: ", i + 1);

                try
                {
                    sayiDizi[i] = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Lütfen sayı değeri giriniz");
                    sayiDizi[i] = int.Parse(Console.ReadLine());
                }
            }

     
            int[] minDeger = new int[3]; //Minimum istenen değer sayısı
            int[] maxDeger = new int[3]; //Maximum istenen değer sayısı
            Array.Sort(sayiDizi);
            double minDegerOrt = 0;
            for (int i = 0; i < minDeger.Length; i++)
            {
                minDeger[i] = sayiDizi[i];
            }
            System.Console.WriteLine("Dizideki En küçük 3 Eleman");
            foreach (var item in minDeger)
            {
                System.Console.WriteLine(item);
                minDegerOrt += item;
            }
            double maxDegerOrt = 0;
            Array.Reverse(sayiDizi);
            for (int i = 0; i < maxDeger.Length; i++)
            {
                maxDeger[i] = sayiDizi[i];
            }
            System.Console.WriteLine("Dizideki En Büyük 3 Eleman");
            foreach (var item in maxDeger)
            {
                System.Console.WriteLine(item);
                maxDegerOrt += item;
            }

            System.Console.WriteLine("Küçükler Dizisinin Ortalaması: " + minDegerOrt / minDeger.Length);
            System.Console.WriteLine("Byükler Dizisinin Ortalaması: " + maxDegerOrt / maxDeger.Length);
            System.Console.WriteLine("Küçükler Dizisinin Ortalama Toplamları: " + minDegerOrt);
            System.Console.WriteLine("Büyükler Dizisinin Ortalama Toplamları: " + maxDegerOrt);
        }
    }
}