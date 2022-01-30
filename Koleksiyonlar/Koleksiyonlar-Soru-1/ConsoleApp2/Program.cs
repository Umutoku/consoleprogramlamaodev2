using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı gir");
            ArrayList d = new ArrayList();
            
            for (int i = 0; i < 5; i++)
            {
                var value = Regex.Replace(Console.ReadLine(),"[^0-9]*$","");
                if (value != string.Empty && Convert.ToInt32(value)>=0)
                {
                    d.Add(Convert.ToInt32(value));
                }

                
            }
            ArrayList asal = new ArrayList();
            ArrayList none = new ArrayList();

            for (int i = 0; i < d.Count; i++)
            {
                int s = 0;
                for (int j = 2; j <= Convert.ToInt32(d[i]); j++)
                {
                    if (Convert.ToInt32(d[i]) % j == 0)
                    {
                        s++;
                    }
                    
                }

                if (s == 1)
                {
                    asal.Add(d[i]);
                }
                else none.Add(d[i]);
            }

            asal.Sort();
            none.Sort();
            Console.WriteLine("Asal Sayılar");
            int noneT = 0;
            int asalT = 0;
            foreach (var item in asal)
            {
                Console.WriteLine(item);
                asalT += Convert.ToInt32(item);
            }
            

            Console.WriteLine("---------------------- \n Asal Olmayan Sayılar");
            foreach (var item in none)
            {
                Console.WriteLine(item);
                noneT += Convert.ToInt32(item);
            }


            Console.WriteLine("\n -------------------- \n Asal Ortalama= " + asalT / asal.Count);
            Console.WriteLine("\n -------------------- \n Asal Olmayan Ortalama= " + noneT / none.Count);
           
        }
    }
}
