using System;

namespace döngüler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1den başlayarak console girilen sayıya kadar ortalama hesaplama
            int sayi=int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while (sayac<=sayi)
            {
                toplam=toplam+sayac;
                sayac++;
                
            }
            Console.WriteLine(toplam/sayi);
            // a dan z ye tüm harfleri yazdır
            char character='a';
            while (character<'z')
            {
                Console.Write(character);
                character++;
            }
            string[] arabalar={"a","b","c"};
            foreach (var araba in arabalar)

            {
            Console.WriteLine(araba);    
            }
        }
    }
}
