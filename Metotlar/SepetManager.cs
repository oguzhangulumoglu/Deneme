using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention -- isimlendirme 
        public void Ekle (Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urun.Adi);

        }
        //yanlış kullanım class değildir alt satır kısmı
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) 
        {
            Console.WriteLine("Tebrikler: Sepete Eklendi : " + urunAdi);
        }
    }
}
