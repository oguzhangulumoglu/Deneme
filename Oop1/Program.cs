﻿using System;

namespace Oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem" };

            //PascalCase    //camelCase
            //case sensitive--büyük küçük harf duyarlı classlar büyük harfle başlar
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            productManager.Topla2(3, 6);

            int toplamaSonucu = productManager.Topla(3, 6);

            Console.WriteLine(toplamaSonucu*2);

            //int,double,bool ... değer tip
            //diziler,class,abstract,interface referans tip

        }
    }
}