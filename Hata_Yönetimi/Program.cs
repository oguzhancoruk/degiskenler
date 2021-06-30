using System;

namespace Hata_Yönetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                 Console.WriteLine("Bir Sayı Giriniz");
           int sayi =Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Girmiş Olduğunuz Sayı"+sayi);
             }
            catch(Exception ex)
            {
Console.WriteLine("Hata:"+ex.Message.ToString());
            }
            finally{
                Console.WriteLine("İşlem tamamlandı");

            }


            try
            {
                //int a=int.Parse(null);
                int a =int.Parse("test");
                int b =int.Parse("-20000000000");
            }
            catch (ArgumentException ex)

            
        {
            Console.WriteLine("Boş değer girdiniz");
            Console.WriteLine(ex);
                
                
            }
            catch(FormatException ex)
            {
                Console.WriteLine("veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {

                Console.WriteLine("çok küçük yada büyük sayı girdiniz");
                Console.WriteLine(ex);
            }
finally{
    Console.WriteLine("işlem başarıyla gerçeklesşti");
}

           
        }
    }
}
