﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Individual
    //gerçek müşteride bir müşteridir.
    class GercekMusteri:Musteri
    {      
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
    }
}
