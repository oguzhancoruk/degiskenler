using System;

namespace Static_Sınıf_ve_Üyeler
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Çalışan Sayısı:"+Calisan.CalisanSayisi);
            Calisan calisan1=new Calisan("ayşe","yılmaz","ika");
             Console.WriteLine("Çalışan Sayısı:"+Calisan.CalisanSayisi);
             Calisan calisan2=new Calisan("deniz","arda","ika");
             Calisan calisan3=new Calisan("oğuzhan","çoruk","ika");
             Console.WriteLine("Çalışan Sayısı:"+Calisan.CalisanSayisi);

           

          Console.WriteLine("toplama işlemi sonucu:"+Islemler.Topla(100,200)) ; 
        Console.WriteLine("toplama işlemi sonucu:"+Islemler.Cıkar(250,125)) ; 
            
        }
    }

    class Calisan{

        private static int calisanSayisi;

        public static int CalisanSayisi 
        {
             get => calisanSayisi;
            
        }

        private string Isim;
        private string Soyisim;
        private string Departman;
        static Calisan(){
            calisanSayisi=0;
        }
        public Calisan(string ısim, string soyisim, string departman)
        {
           this.Isim = ısim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }



    static class Islemler
    {

        public static long Topla(int sayi1,int sayi2)
        {

              return sayi1+sayi2;

        }

         public static long Cıkar(int sayi1,int sayi2)
        {

              return sayi1-sayi2;

        }
    }
}
