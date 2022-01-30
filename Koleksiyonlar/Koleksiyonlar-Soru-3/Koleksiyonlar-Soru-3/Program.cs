using System;
using System.Collections.Generic;

namespace soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> sesliListe = new List<char>();
string sesliKarakter = "aeıioöuü";
System.Console.WriteLine("Lütfen Bir Kelime Girin: ");
string metin = Console.ReadLine().ToLower();
for (int i = 0; i < metin.Length; i++)
{
    if (sesliKarakter.Contains(metin[i]))
    {
        sesliListe.Add(metin[i]);
    }
}
if (sesliListe.Count > 0)
{
    foreach (var item in sesliListe)
    {
        System.Console.WriteLine(item);
    }
}
else
{
    System.Console.WriteLine("Girilen Cümlede Sesli Harf Bulunmamaktadır.");
}
        }
    }
}