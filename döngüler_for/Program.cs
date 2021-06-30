using System;

namespace döngüler_for
{
    class Program
    {
        static void Main(string[] args)
        {int sayac= Convert.ToInt32(Console.ReadLine());
           for (int i = 0; i < sayac; i++)
           {
               if(i%2==1)
               Console.WriteLine(i);
               
           }
// 1 ile 1000 arasındaki çift ve tek sayıların toplamı
int tektoplam=0;
int  cifttoplam=0;
for (int i = 1; i <=1000 ; i++)
{
    if(i%2==0)
    cifttoplam=cifttoplam+i;
    if(i%2==1)
    tektoplam=tektoplam+i;
    
}
Console.WriteLine("Cift sayilarin toplami: "+cifttoplam);
Console.WriteLine("Tek sayilar toplami: "+tektoplam);

//break, countinue
for (int i = 1; i < 10; i++){
    if(i==4)
    break;
    Console.WriteLine(i);

    
}
for (int i = 1; i < 10; i++)
{
    if(i==4)
    continue;
    Console.WriteLine(i);
}
        }
    }
}
