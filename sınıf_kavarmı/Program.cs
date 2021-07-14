using System;

namespace sınıf_kavarmı
{
    class Program
    {
        static void Main(string[] args)
        {
            

            calisan calisan1=new calisan();
            calisan1.ad="Ayşe";
            calisan1.soyad="Kara";
            calisan1.no=12345678;
            calisan1.depertman="İnsan Kaynakları";
            calisan1.calisanbilgileri();
            Console.WriteLine("*********");

            calisan calisan2=new calisan();

            calisan2.ad="Deniz";
            calisan2.soyad="Arda";
            calisan2.no=36589214;
            calisan2.depertman="Satın Alma";
            calisan2.calisanbilgileri();
            
        }
   
    }

    class calisan
    {
     public string ad;
     public string soyad;
     public int no;
     public string depertman;

     public void calisanbilgileri()
     {

         Console.WriteLine("Çalışan Adı:"+ad);
         Console.WriteLine("Çalışan Soyad:"+soyad);
         Console.WriteLine("Çalışan Numarası:"+no);
         Console.WriteLine("Çalışanın Depertmanı:"+depertman);
     }

    }
}
