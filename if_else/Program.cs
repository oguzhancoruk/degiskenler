using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int time=DateTime.Now.Hour;

            if(time>=6 && time<=11)
            Console.WriteLine( "günaydın");
            else if(time <18)
            Console.WriteLine("İyi günler");
            else
            Console.WriteLine("iyigeceler");

            string sonuc= time<=18 ? "iyi günler":"iyigeceler";
            sonuc= time>=6 && time<11 ?"günaydın":time<=18 ? "iyi günler":"iyi geceler";
            Console.WriteLine(sonuc);
        }
    }
}
