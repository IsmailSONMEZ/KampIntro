using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class SmsLogerManager : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("sms gönderildi");
        }
    }
}
