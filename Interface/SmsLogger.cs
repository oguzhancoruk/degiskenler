using System;

namespace Interface
{
    public class SmsLogger : ILogger
    {
        public void Writelog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("sms olarak log yazar");
        }
    }
}