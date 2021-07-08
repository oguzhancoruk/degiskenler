using System;

namespace soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.WriteLine("Lütfen Pozitif 2 Tam Sayı Giriniz:");
            
           
           int a=Convert.ToInt32(Console.ReadLine());
           int b=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen"+" "+a+" " +"Adet Pozitf Tam Sayı Giriniz");
 int[] c =new int[a]; 
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine("Lütfen"+" "+i+" " +". Sayıyı Giriniz");
              c[i-1] =Convert.ToInt32(Console.ReadLine());
              
            }

            foreach (var cift in c)

            {
                
                if(cift%b==0||cift==b)
                    
                
                  Console.WriteLine(cift);
               
                
            }

            
            
            
              
     

        }}
        
}