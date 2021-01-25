using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager
    {
        //method injection - bu metodun hangi kredi türü ve hangi
        //loglayıcı olacağını belirtiyoruz
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //başvuran bilgilerini değerlendirme
            // vs işlemler

            
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List <IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
