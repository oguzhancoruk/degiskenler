using System;

namespace dizi_metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort
            int[] sayidizi ={23,12,86,72,3,11,17};
            foreach (var sayi in sayidizi)
           
            Console.WriteLine(sayi) ;

            Array.Sort(sayidizi);
            foreach (var sayi in sayidizi)
            Console.WriteLine(sayi); 

            //clear

         
         Array.Clear(sayidizi,2,2);
         foreach (var sayi in sayidizi)
         Console.WriteLine(sayi) ;

         // reverse

         Array.Reverse(sayidizi);
         foreach (var sayi in sayidizi)
           
         Console.WriteLine(sayi) ;

         //indexof

         Array.IndexOf(sayidizi,3);
         foreach (var sayi in sayidizi)
           
         Console.WriteLine(sayi) ;

         Console.WriteLine(Array.IndexOf(sayidizi,3));

         //resize

        Array.Resize<int>(ref sayidizi,9);
        sayidizi[8]=99;
         foreach (var sayi in sayidizi)
           
            Console.WriteLine(sayi) ;




            
            
        }
    }
}
