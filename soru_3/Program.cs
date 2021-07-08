using System;

namespace soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
             Console.WriteLine("Lütfen Pozitif Bir Tam Sayı Giriniz:");
            
           
           int a=Convert.ToInt32(Console.ReadLine());
           
 string[] c =new string[a]; 
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine("Lütfen"+" "+i+" " +". Kelimeyi Giriniz");
              c[i-1] =Convert.ToString(Console.ReadLine());
             
              
            }
             Array.Reverse(c);

            foreach (var cift in c)

            {
                
               
                    
                
                  Console.WriteLine(cift);
               
                
            }
        }
    }
}
