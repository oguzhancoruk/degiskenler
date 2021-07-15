using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
           
          Diktörtgen dikdörtgen =new Diktörtgen();
          dikdörtgen.KisaKenar=3;
          dikdörtgen.UzunKenar=4;

          Console.WriteLine("class alan hesabı:"+dikdörtgen.AlanHesapla());

          dikdörtgen_Struct dikdörtgen_Structt = new dikdörtgen_Struct(3,4); 
          
          
          Console.WriteLine("class alan hesabı:"+dikdörtgen_Structt.AlamHesapla());
          

 
        }
    }


    class Diktörtgen
    {


        public int KisaKenar;
        public int UzunKenar;
         

        public Diktörtgen()
        {

            KisaKenar=3;
            UzunKenar=4;
        } 

         

        public long AlanHesapla()
         {

             return this.KisaKenar*UzunKenar;
         }



    }
    

    struct dikdörtgen_Struct
    {

        public int Kisakenar;
        public int Uzunkenar;
        public dikdörtgen_Struct(int kisakenar = 0, int uzunkenar = 0)
        {
            Kisakenar = kisakenar;
            Uzunkenar = uzunkenar;
        }
        public long AlamHesapla()
        {

            return this.Kisakenar*this.Uzunkenar;
        }
    }
}
