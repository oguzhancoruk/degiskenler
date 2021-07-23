using System;

namespace Interface
{
    public class FileLogger : ILogger
    {
        public void Writelog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("dosyaya log yazar");
        }
    }
}