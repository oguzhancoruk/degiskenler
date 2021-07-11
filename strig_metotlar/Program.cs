using System;

namespace strig_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           string degisken="dersimiz Csharp. Hoşgeldiniz";
           string degisken2="dersimiz Csharp";
           //lenght
           Console.WriteLine(degisken.Length);

           //ToUpper ,ToLower
           Console.WriteLine(degisken.ToUpper());
           Console.WriteLine(degisken.ToLower());

           //concat

           Console.WriteLine(string.Concat(degisken,"merhaba"));

           //compare, compareto

           Console.WriteLine(degisken.CompareTo(degisken2));
           Console.WriteLine(string.Compare(degisken,degisken2,true));
           Console.WriteLine(string.Compare(degisken,degisken2,false));

           //contains

           Console.WriteLine(degisken.Contains(degisken));
           Console.WriteLine(degisken.EndsWith("hpşgeldiniz"));
           Console.WriteLine(degisken.StartsWith("merhaba"));

           //indexof

           Console.WriteLine(degisken.IndexOf("cs"));
           Console.WriteLine(degisken.IndexOf("oğuzhan"));
           Console.WriteLine(degisken.LastIndexOf("i"));
           //insert
           Console.WriteLine(degisken.Insert(0,"merhaba"));

           //padleft,padright

           Console.WriteLine(degisken+degisken2.PadLeft(30));
           Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
           Console.WriteLine(degisken.PadRight(50)+degisken2);
           Console.WriteLine(degisken.PadRight(50,'*')+degisken2);

           //remove
           Console.WriteLine(degisken.Remove(10));
           Console.WriteLine(degisken.Remove(5,3));
           Console.WriteLine(degisken.Remove(0,1));

           //replace

           Console.WriteLine(degisken.Replace("Csharp","c#"));
           Console.WriteLine(degisken.Replace(" ","*"));

           //split
           Console.WriteLine(degisken.Split(' ')[4]);
           Console.WriteLine(degisken.Substring(4,6));

           

        }
    }
}
