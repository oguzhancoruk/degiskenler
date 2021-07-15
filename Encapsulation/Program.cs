using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrencii=new Ogrenci();
            ogrencii.Isim="ayşe";
            ogrencii.Soyisim="yılmaz";
            ogrencii.OgrenciNo=293;
            ogrencii.Sinif=3;
            ogrencii.OgrenciBilgileriniGetir();
            ogrencii.SinifAtla();
            ogrencii.OgrenciBilgileriniGetir();
            Ogrenci ogrencii1=new Ogrenci("deniz","arda",256,1);
            ogrencii1.Sinifdus();
             ogrencii1.Sinifdus();

            ogrencii1.OgrenciBilgileriniGetir();


        }
  
    
    
    }


    class Ogrenci{

        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { 
            get => isim;
            set => isim = value;
          }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { get => sinif;
         set{
             if(value<1)
             {
             Console.WriteLine("Sınıf En Az 1 Olabilir!"); 
             sinif = 1;
             }
             else 
             sinif=value;
             }
          }
    
        public Ogrenci(string isim,string soyisim,int ogrencino,int sinif){
        Isim=isim;
        Soyisim=soyisim;
        OgrenciNo=ogrencino;
        Sinif=sinif;
       

        }
        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {

         Console.WriteLine("****Öğrenci Bilgileri****");
         Console.WriteLine("Öğrencinin Adı   :"+this.Isim);
         Console.WriteLine("Öğrencinin Soyadı   :"+this.Soyisim);
         Console.WriteLine("Öğrencinin No   :"+this.OgrenciNo);
         Console.WriteLine("Öğrencinin Sınıfı   :"+this.Sinif);


        }


        public void SinifAtla()
        {

            this.Sinif=this.Sinif+1;
        }

        public void Sinifdus()
        {

            this.Sinif=this.Sinif-1;
        }
    
    }
}
