using System;

namespace Recursive_Extension_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif- öz yinelemeli
            //3^4
            int sonuc=1;
            for (int i = 1; i < 5; i++)
            {
                
                sonuc=sonuc*3;
                
                
            }
            Console.WriteLine(sonuc);
            islemler instance= new();
                Console.WriteLine(instance.expo(3,4));
                // extension metotlar

                string ifade ="oğuzhan çoruk";
                bool sonuc1=ifade.checkspaces();
                Console.WriteLine(sonuc);
                if(sonuc1)
                

                   { Console.WriteLine(ifade.removespaces());
                   Console.WriteLine(ifade.makeupper());
                   Console.WriteLine(ifade.lover());
                   }int[] dizii={ 9,3,6,2,1,5,0};
                dizii.sortarry();
                dizii.ekranayazdır();

                int sayii=5;
                
                Console.WriteLine(sayii.ısevennumber());
                Console.WriteLine(ifade.getfirst());
                
                
            }    

              
        }
        public  class islemler 
        {

            public int expo(int sayi,int üs)
            {
                if(üs<2)
                return sayi;
                return expo(sayi,üs-1)*sayi;
            }
        }

       
    
            
        
    
     public static class Extension{
            

            public static bool checkspaces( this string param )
            {
                return param.Contains(" ");
            }
            public static string removespaces(this string param)
            {

                string[] dizi=param.Split(" ");
                return string.Join("",dizi);
            }
            public static string makeupper(this string param)
            {

                
                return param.ToUpper();
            }
            public static string lover(this string param)
            {

                
                return param.ToLower();
            }
            public static int[] sortarry(this int[] param)
            {

                Array.Sort(param);
                return param;
            }
            public static void ekranayazdır(this int[] param)
            {

            foreach (var item in param)
            Console.WriteLine(item);
                
            }
            public static bool ısevennumber( this int param)
            {
                return param%2==0;
            }
            public static string getfirst( this string param)
            {

             return param.Substring(0,1);

            }

        }
}
