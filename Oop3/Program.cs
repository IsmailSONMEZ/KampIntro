using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();          

            IKrediManager tasitKrediManager = new TasitKrediManager();           

            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();



            ILoggerService loggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
           basvuruManager.BasvuruYap(ihtiyacKrediManager, new List<ILoggerService>() {new DatabaseLoggerService(), new SmsLogerManager() });

            List<IKrediManager> krediler = new List<IKrediManager>() {tasitKrediManager, ihtiyacKrediManager};
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
