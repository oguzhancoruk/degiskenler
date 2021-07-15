using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(Gunler.pazar);
           Console.WriteLine((int)Gunler.cumartesi);

            int sicaklik=32;
            if(sicaklik<=(int)HavaDurumu.normal){
            Console.WriteLine("Dışasıya çıkmak için serin");}  
            else if(sicaklik>=(int)HavaDurumu.sıcak){
            Console.WriteLine("dişarıçıkmak için  sıcak");
            }
            else if(sicaklik>=(int)HavaDurumu.normal)
            {
            Console.WriteLine("hava güzel");
            }
                
                 

            
        }
    }

    enum Gunler
    {
       pazartesi=1,
       sali,
       carsamba,
       persembe,
       cuma=23,
       cumartesi,
       pazar
    }

    enum HavaDurumu
    {
      soguk=5,
      normal=20,
      sıcak=25,
      coksıcak=30
      

    }
}
