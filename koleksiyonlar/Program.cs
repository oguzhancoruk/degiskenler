using System;
using System.Collections.Generic;

namespace koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T-> object türündedir

            List<int> sayilistesi= new List<int>();

            sayilistesi.Add(23);
            sayilistesi.Add(10);
            sayilistesi.Add(4);
            sayilistesi.Add(5);
            sayilistesi.Add(92);
            sayilistesi.Add(34);

            List<string> renklistesi=new List<string>();

            renklistesi.Add("kırmızı");
            renklistesi.Add("mavi");
            renklistesi.Add("turuncu");
            renklistesi.Add("sarı");
            renklistesi.Add("yeşil");

            //count
            Console.WriteLine(renklistesi.Count);
            Console.WriteLine(sayilistesi.Count);

            foreach (var sayi in sayilistesi)
            {
                Console.WriteLine(sayi);
            }
            
            foreach (var renk in renklistesi)
            {
                Console.WriteLine(renk);
            }

            sayilistesi.ForEach(sayi=> Console.WriteLine(sayi));
            renklistesi.ForEach(renk=> Console.WriteLine(renk) );
            //listeden elemean çıkarma

            sayilistesi.Remove(4);
            renklistesi.Remove("yeşil");

            sayilistesi.RemoveAt(0);
            renklistesi.RemoveAt(1);

            sayilistesi.ForEach(sayi => Console.WriteLine(sayi));
            renklistesi.ForEach(renk => Console.WriteLine(renk));

            //liste içerisinde arama

            if(sayilistesi.Contains(10))
            Console.WriteLine("10 liste içerisinde bulundu");

            // eleman ile index'e erişme
            Console.WriteLine(renklistesi.BinarySearch("sarı"));

            //diziyi listeye cevirme

            string[] hayvanlar={"kedi","köpek","kuş"};
            List<string> hayvanlarlistesi=new List<string>(hayvanlar);
            
            //liste içerisinde nesne tutmak

            List<kullanıcılar>kullanıcılistesi=new List<kullanıcılar>();
            kullanıcılar kullanıcı1=new kullanıcılar();
            kullanıcı1.Isım="ayşe";
            kullanıcı1.SoyIsım="yılmaz";
            kullanıcı1.Yas=26;

            kullanıcılar kullanıcı2=new kullanıcılar();

            kullanıcı2.Isım="oğuzhan";
            kullanıcı2.SoyIsım="çoruk";
            kullanıcı2.Yas=25;
            kullanıcılistesi.Add(kullanıcı1);
            kullanıcılistesi.Add(kullanıcı2);

            List<kullanıcılar>yeniliste =new List<kullanıcılar>();

            yeniliste.Add(new kullanıcılar()
            {
            Isım="MUSTAFA",
            SoyIsım="YUMLU",
            Yas=61
            });
            
            foreach(kullanıcılar kullanıcı in kullanıcılistesi){
            Console.WriteLine("Kullanıcı Adı:"+kullanıcı.Isım);
            Console.WriteLine("Kullanıcı Soyadı:"+kullanıcı.SoyIsım);
            Console.WriteLine("Kullanıcı Yaşı:"+kullanıcı.Yas);
             }

            
             



    
        }

        public class kullanıcılar{

            private string isim;
            private string soyisim;
            private int yas;
            public string Isım{get=>isim;set=>isim=value;}
            public string SoyIsım{get=>soyisim;set=>soyisim=value;}
            public int Yas{get=>yas;set=>yas=value;}

        }
    }

}
