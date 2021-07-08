using System;

namespace soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.WriteLine("Lütfen Pozitif Bir Tam Sayı Giriniz:");
            
           
           int a=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen"+" "+a+" " +"Adet Pozitf Tam Sayı Giriniz");
 int[] c =new int[a]; 
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine("Lütfen"+" "+i+" " +". Sayıyı Giriniz");
              c[i-1] =Convert.ToInt32(Console.ReadLine());
              
            }

            foreach (var cift in c)

            {
                
                if(cift%2==0)
                    
                
                  Console.WriteLine(cift);
               
                
            }
            
            
              
     

        }}
        
}