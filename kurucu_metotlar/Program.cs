using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {    Console.WriteLine("**** Çalışan 1*****");
           calisan calisan1=new calisan("Ayşe","Kara",12345678,"İnsan Kaynakları");
      
            calisan1.calisanbilgileri();
            Console.WriteLine("**** Çalışan 2*****");

            calisan calisan2=new calisan();

            calisan2.ad="Deniz";
            calisan2.soyad="Arda";
            calisan2.no=36589214;
            calisan2.depertman="Satın Alma";
            calisan2.calisanbilgileri();

             Console.WriteLine("**** Çalışan 3*****");
             calisan calisan3=new calisan("oğuzhan","çoruk");
             
             calisan3.calisanbilgileri();
            
        }
   
    }
    class calisan
    {
     public string ad;
     public string soyad;
     public int no;
     public string depertman;

     public calisan(string Ad, string Soyad,int No,string Departman)
     {
          this.ad=Ad;
          this.soyad=Soyad;
          this.no=No;
          this.depertman=Departman;
          

     }
     public calisan(string Ad, string Soyad)
     {
          this.ad=Ad;
          this.soyad=Soyad;
         
          

     }

public calisan(){}
     public void calisanbilgileri()
     {

         Console.WriteLine("Çalışan Adı:"+ad);
         Console.WriteLine("Çalışan Soyad:"+soyad);
         Console.WriteLine("Çalışan Numarası:"+no);
         Console.WriteLine("Çalışanın Depertmanı:"+depertman);
     }
     }}