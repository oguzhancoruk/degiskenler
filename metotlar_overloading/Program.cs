using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out paremetreler
            string sayi="999";
            int outsayi;

            int.TryParse(sayi,out  outsayi);
            bool sonuc=int.TryParse(sayi,out  outsayi);
            if(sonuc)
            {

                Console.WriteLine("başarili");
                Console.WriteLine(outsayi);
            }
            else{
                Console.WriteLine("başarıız");
            }
            metotlar insatance=new metotlar();
            insatance.Topla(4,5,out int toplamsonuc);
            Console.WriteLine(toplamsonuc);
            //metot aşırı yükleme
            int ifade=999;
            insatance.ekranayazır(Convert.ToString(ifade));
            insatance.ekranayazır(ifade);
            insatance.ekranayazır("oğuzhan","çoruk");




            

        }

        class metotlar {

            public void Topla(int a, int b,out int toplam)
            {
                toplam=a+b;
            }

            public void ekranayazır(string veri)
            {

                Console.WriteLine(veri);
            }
             public void ekranayazır(int veri)
            {

                Console.WriteLine(veri);
            }
             public void ekranayazır(string veri1,string veri2)
            {

                Console.WriteLine(veri1+veri2);
            }
        }
    }
}
