using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger=new FileLogger();
            fileLogger.Writelog();

            DatabaseLogger databaseLogger=new DatabaseLogger();
            databaseLogger.Writelog();

            SmsLogger smsLogger=new();
            smsLogger.Writelog();
            LogManager logManager=new LogManager(new FileLogger());
            logManager.Writelog();
        }
    }
}
