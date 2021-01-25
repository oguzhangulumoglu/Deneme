using System;
using System.Collections.Generic;

namespace Odev4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();
            ogrenciler.Ekle(1, "Oğuzhan Gülümoğlu");
            ogrenciler.Ekle(2, "Dilan Duman");

            //ogrenciler.Listele();

            ogrenciler.Ekle(3, "Fikret");
            ogrenciler.Ekle(4, "Erdoğan");
            ogrenciler.Listele();

            //ogrenciler.Ekle(1, "Yeni Öğrenci");
            //ogrenciler.Listele();

            //ogrenciler.Listele(2);



        }


    }
}