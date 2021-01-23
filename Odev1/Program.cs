using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {

            BilgisayarTablet bilgisayarTablet1 = new BilgisayarTablet();
            bilgisayarTablet1.Ad = "Apple Mini Tab";
            bilgisayarTablet1.Marka = "Apple";
            bilgisayarTablet1.Fiyat = 3600;

            BilgisayarTablet bilgisayarTablet2 = new BilgisayarTablet();
            bilgisayarTablet2.Ad = "Samsung";
            bilgisayarTablet2.Marka = "S Tab";
            bilgisayarTablet2.Fiyat = 2800;

            BilgisayarTablet bilgisayarTablet3 = new BilgisayarTablet();
            bilgisayarTablet3.Ad = "Reader";
            bilgisayarTablet3.Marka = "Çöp";
            bilgisayarTablet3.Fiyat = 100;

            BilgisayarTablet[] TabletModel = new BilgisayarTablet[] { bilgisayarTablet1, bilgisayarTablet2 , bilgisayarTablet3 };

            Console.WriteLine("For Each Döngü Örneği");
            foreach (var bilgisayarTablet in TabletModel)
            {
                Console.WriteLine(bilgisayarTablet.Ad + " : "  +  bilgisayarTablet.Marka + " : " +  bilgisayarTablet.Fiyat);
            }
            Console.WriteLine("\n");
            Console.WriteLine("For Döngü Örneği");
            for (int i = 0; i < TabletModel.Length; i++)
            {
                Console.WriteLine(TabletModel[i].Ad + " : " + TabletModel[i].Marka + " : " + TabletModel[i].Fiyat);
            }
            Console.WriteLine("\n");
            Console.WriteLine("While Döngü Örneği");
            int j = 0;

            while(j<TabletModel.Length)
            {
                Console.WriteLine(TabletModel[j].Ad + " : " + TabletModel[j].Marka + " : " + TabletModel[j].Fiyat);
                j++;
            }











        }
    }

    class BilgisayarTablet
    {
        public string Ad { get; set; }
        public string Marka { get; set; }
        public int Fiyat { get; set; }

    }
}






