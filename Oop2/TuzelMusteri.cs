using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Coorporate
    //miras - inheratance
    //tüzel müşteri bir müşteridir demek alt satırdaki kod
    class TuzelMusteri:Musteri
    {        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
