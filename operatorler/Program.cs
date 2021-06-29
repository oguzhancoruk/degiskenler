using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // atama ve işlemli atama
            int x=3;
            int y=3;
            y=y+2;
            Console.WriteLine(y);
            y+=2;
 Console.WriteLine(y);
            y/=1;
             Console.WriteLine(y);
            x*=2;
             Console.WriteLine(x);

             // mantıksal opaeratörler
             // ||,&&, !

             bool issuccess=true;
             bool iscompleted=false;
             if(issuccess&&iscompleted)
             Console.WriteLine("perfect");
             if(issuccess||iscompleted)
             Console.WriteLine( "great");
             if(issuccess&& !iscompleted)
             Console.WriteLine("fine");

             //ilişkisel operatörler
             //<,>,<=,>=,==,!=

             int a=3;
             int b=4;
             bool sonuc=a<b;

             Console.WriteLine(sonuc);
             sonuc=a>b;
             Console.WriteLine(sonuc);
             sonuc=a<=b; 
             Console.WriteLine(sonuc);
             sonuc=a>=b;
             Console.WriteLine(sonuc);
             sonuc=a==b;
             Console.WriteLine(sonuc);
             sonuc=a!=b;
             Console.WriteLine(sonuc);


//aritmetik operatörler
// /,*,+,-

int sayi1=10;
int sayi2=5;
int sonuc1=sayi1/sayi2;
Console.WriteLine(sonuc1);
sonuc1=sayi1*sayi2;
Console.WriteLine(sonuc1);
sonuc1=sayi1+sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi1++;
Console.WriteLine(sonuc1);

//%:mod alır

int sonuc2=20%3;
Console.WriteLine(sonuc2);








        }
    }
}
