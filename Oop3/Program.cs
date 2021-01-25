using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        //interface lerde referans numarasını tutabilir
        //interfaceleri birbirinin alternatifi olan 
        //ama kod içerikleri farklı olan kod içerikleri için kullanırız.

        static void Main(string[] args)
        {
            //alt satırdaki ilk kod gibide yazılabilir.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();          
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            //bu şekilde kredileri başvuru yap sonrasında tek seferde girebiliriz.

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, new DatabaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
