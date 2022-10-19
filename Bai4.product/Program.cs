using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace Bai4.product
{
    class Bai4 {
        static Product findProduct(Product[] listProduct, string nameProduct)
        {
            for

        }

        static void Main(string[] args)
        {
            Product[] product = new Product[9];
            product[0] = new Product { name = "CPU", price = 750, quality = 10, categoryId = 1 };
            product[1] = new Product { name = "RAM", price = 50, quality = 2, categoryId = 2 };
            product[2] = new Product { name = "HDD", price = 70, quality = 1, categoryId = 2 };
            product[3] = new Product { name = "Main", price = 400, quality = 3, categoryId = 1 };
            product[4] = new Product { name = "Keybroad", price = 30, quality = 8, categoryId = 4 };
            product[5] = new Product { name = "Mouse", price = 25, quality = 50, categoryId = 4 };
            product[6] = new Product { name = "VGA", price = 60, quality = 35, categoryId = 3 };
            product[7] = new Product { name = "Minutor", price = 150, quality = 28, categoryId = 2 };
            product[8] = new Product { name = "Case", price = 120, quality = 28, categoryId = 5 };

            Category[] category = new Category[4];
            category[0] = new Category { name = "Comuter", id = 1 };
            category[1] = new Category { name = "Memory", id = 2 };
            category[2] = new Category { name = "Card", id = 3 };
            category[3] = new Category { name = "Acesory", id = 4 };


        }
    } 
}