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
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urun.Adi + urun.Fiyati + urun.Aciklama);

        }
        //yanlış kullanım. class değildir alt satır kısmı
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) 
        {
            Console.WriteLine("Tebrikler: Sepete Eklendi:  " + urunAdi);
        }
        public void Delete (Urun urun)
        {
            Console.WriteLine("Tebrikler Ürün Silindi:" + urun.Adi  + urun.Fiyati + urun.Aciklama);
        }
        public void List(Urun urun)
        {
            Console.WriteLine("Ürünleriniz Silinmiştir : " + urun.Adi);
        }
    }
}
