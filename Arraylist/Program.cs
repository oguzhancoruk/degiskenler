using System;
using System.Collections;
using System.Collections.Generic;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste=new ArrayList(); 
           // liste.Add("oğuzhan");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('a');

            // verilere erişme

            //Console.WriteLine(liste[1]);
            //foreach (var item in liste)

            //{
              //  Console.WriteLine(item);

                
           // }

            //addrange
            Console.WriteLine("****************");

           // string[] renkler={"kırmızı","sarı","yeşil"};
            List<int>sayılar=new List<int>(){1,8,3,7,9,92,15};
           // liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //sort 
            Console.WriteLine("****sort***");
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);

            }

            //binary search

            Console.WriteLine("*************");
            Console.WriteLine(liste.BinarySearch(9));

            //reverse
            Console.WriteLine("**********");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("********");
            liste.Clear();

            foreach (var item in liste)

            {
            Console.WriteLine(item);    
            }

        }
    }
}
