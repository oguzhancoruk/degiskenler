using System;

namespace Interface
{
    public class DatabaseLogger : ILogger
    {
        public void Writelog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("databasee yazar");
        }
    }
}