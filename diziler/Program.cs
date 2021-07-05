using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] renkler=new string[5];
            string[] hayvanlar={"Kedi","kopek","kuş","MAYMUN"};
            int[] dizi; 
            dizi =new int[5];
            
            //Dizilere değer atama ve erişim

            renkler[0]="mavi";
            dizi[3]=10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // Döngülerle dizi kullanımı
            // n tane sayının ortalamasını hesaplayan program 
            Console.WriteLine("lütfen dizinin eleman sayısısnı giriniz");
            int diziuzunlugu=int.Parse(Console.ReadLine());
            int[] sayi= new int[diziuzunlugu];
            for (int i = 0; i < diziuzunlugu; i++)

            {

                Console.WriteLine("lütfen{0}. sayıyı giriniz",i+1);
                sayi[i]=int.Parse(Console.ReadLine());

                
            }
            int toplam=0;
        foreach (var say in sayi)
        {
            toplam += say;
            Console.WriteLine("ortalama :"+toplam/diziuzunlugu);
        }
        
        
        }


    }
}
