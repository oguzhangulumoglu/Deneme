using System;
using System.Collections.Generic;
using System.Text;

namespace Oop1
{
    class ProductManager
    {
        //metotun nasıl çağırılacağı alan
        //encapsulation
        public void Add(Product product) //örneğin string türünde değer ver demek gibi
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

        //işlemin sonucunda daha sonra Topla'yı geri getirebilirsin
        public int Topla(int sayi1,int sayi2) 
        {
            return sayi1 + sayi2;
        }
        //işlemin sonucunda sadece sonucu verir daha sonra geri getiremezsin
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
