using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int mount= DateTime.Now.Month;
            switch (mount) 
            {
                case 1:
                Console.WriteLine("ocaj ayındsınız");
                break;
                 case 2:
                Console.WriteLine("subat ayındsınız");
                break;
                 case 3:
                Console.WriteLine("mart ayındsınız");
                break;
                 case 5:
                Console.WriteLine("mayıs ayındsınız");
                break;
                 case 4:
                Console.WriteLine("nisan ayındsınız");
                break;
                 case 6:
                Console.WriteLine("hazıran ayındsınız");
                break;
                default:
                break;
            }
            switch (mount)
            {case 12:
            case 1:
            case 2:
            Console.WriteLine("kış ayındasınız");
                break;
            case 3:
            case 4:
            case 5:
            Console.WriteLine("ilk bahar ayındasınız");
            break;
            case 6:
            case 7:
            case 8:
            Console.WriteLine("yaz ayındasınız");
                break;
            case 9:
            case 10:
            case 11:
            Console.WriteLine("sonbahar ayındasınız");
                break;
                default:
                break;
            }
            
        }
    }
}
