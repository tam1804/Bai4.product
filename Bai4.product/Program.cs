using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace Bai4.product
{
    class Bai4 {
        static Product findProduct(Product[] listProduct, string nameProduct)
        {
            Product productSameName = new Product();
            for (int i = 0; i < listProduct.Length; i++)
            {
                if (listProduct[i].name == nameProduct)
                {   
                    productSameName = listProduct[i];
                    break;
                }
            }
            return productSameName;
        }

        static Product[] findProductByCategory(Product[] listProduct, int categoryId)
        {
            int numberSameId = 0;
            for(int i = 0; i < listProduct.Length; i++)
            {
                if(listProduct[i].categoryId == categoryId)
                {
                    numberSameId++;    
                }
            }
            Product[] productSameId = new Product[numberSameId];
            int j = 0;
             for (int i = 0; i < listProduct.Length; i++)
                {
                if (listProduct[i].categoryId == categoryId)
                {
                    productSameId[j++] = listProduct[i];
                }
                }
             return productSameId;
            
        }
        static Product[] findProductByPrice(Product[] listProduct, int price)
        {
            int numberProductLessPrice = 0;
            for(int i = 0; i < listProduct.Length; i++)
            {
                numberProductLessPrice++;
            }
            Product[] productLessPrice = new Product[numberProductLessPrice];
            int j = 0;
            for(int i = 0; i < numberProductLessPrice; i++)
            {
                if (listProduct[i].price <= price)
                {
                    productLessPrice[j++] = listProduct[i];
                }
            }
            return productLessPrice;
        }
        static Product[] sortByPrice(Product[] listProduct)
        {
            Product productTemporary = new Product();
            for(int i = 0; i < listProduct.Length; i++)
            {
                for( int j = i + 1; j < listProduct.Length;j++ )
                {
                    if (listProduct[i].price > listProduct[j].price)
                    {
                        productTemporary = listProduct[i];
                        listProduct[i] = listProduct[j];
                        listProduct[j] = productTemporary;
                    }
                }
            }
            return listProduct;
        }
        static Product[] sortByName(Product[] listProduct)
        {
            Product productTemporary = new Product();
            for(int i = 0; i < listProduct.Length - 1; i++)
            {
                for(int j = 0; j < listProduct.Length - 1; j++)
                {
                    if((listProduct[j].name).Length < (listProduct[j + 1].name).Length)
                    {
                        productTemporary = listProduct[j];
                        listProduct[j] = listProduct[j + 1];
                        listProduct[j+1] = productTemporary;
                    }
                }
            }
            return listProduct;
        }
        static Product minByPrice(Product[] listProduct)
        {
            int minPrice = listProduct[0].price;
            for(int i = 1; i < listProduct.Length; i++)
            {
                if(listProduct[i].price < minPrice)
                {
                    minPrice = listProduct[i].price;
                }
            }
            for(int i = 1; i < listProduct.Length; i++)
            {
                if(minPrice == listProduct[i].price)
                {
                    return listProduct[i];
                }
            }
            return listProduct[0];
        }
        static Product maxByPrice(Product[] listProduct)
        {
            int maxPrice = listProduct[0].price;
            for (int i = 1; i < listProduct.Length; i++)
            {
                if (listProduct[i].price > maxPrice)
                {
                    maxPrice = listProduct[i].price;
                }
            }
            for (int i = 1; i < listProduct.Length; i++)
            {
                if (maxPrice == listProduct[i].price)
                {
                    return listProduct[i];
                }
            }
            return listProduct[0];
        }
        static float calSalary(float salary, float n)
        {
            if(n == 0)
            {
                return salary;
            } else
            {
                return calSalary(salary, n -1)*110/100;
            }
        }
        static float calSalaryBasic(float salary, float n)
        {   
            while(n> 0)
            {
                salary = salary + salary / 10;
                n--;
            }
            return salary;
        }
        static int callMonth(float money, float rate, int month = 0)
        {
            if(rate*month*money/100 >= money)
            {
                return month;
            } else
            {
                return callMonth(money, rate, ++month);
            }
            return month;
        }
        static int callMonthBasic(float money, float rate)
        {
            int month = 0;
            while(month*rate*money/100 < money)
            {
                month++;
            }
            return month;
        }
        static Product[] sortByCategoryName(Product[] listProduct, Category[] listCategory)
        {
            Category categoryTemporary = new Category();
            for(int i = 0; i < listCategory.Length; i++)
            {
                for(int j = i+1; j < listCategory.Length; j++)
                {
                    if (listCategory[i].name[0] > listCategory[j].name[0])
                    {
                        categoryTemporary = listCategory[i];
                        listCategory[i] = listCategory[j];
                        listCategory[j] = categoryTemporary;
                    }
                }
            }
            Product productTemporary = new Product();
            Product[] products = new Product[listProduct.Length];
            int countVariablelProduct = 0;
            for (int i = 0; i < listCategory.Length; i++) {
                for(int j = 0; j < listProduct.Length; j++)
                {
                    if(listCategory[i].id ==listProduct[j].categoryId)
                    {
                        products[countVariablelProduct++] = listProduct[j];
                    }
                }
            }
            return products;
        }
        static ProductHaveCategoryName[] mapProductByCategory(Product[] listProduct, Category[] listCategory)
        {
            ProductHaveCategoryName[] productHaveCategoryName = new ProductHaveCategoryName[listProduct.Length];
            for(int i = 0;i < listProduct.Length; i++)
            {
                productHaveCategoryName[i] = new ProductHaveCategoryName();
                productHaveCategoryName[i].name = listProduct[i].name;
                productHaveCategoryName[i].price = listProduct[i].price;
                productHaveCategoryName[i].categoryId = listProduct[i].categoryId;
                productHaveCategoryName[i].quality = listProduct[i].quality;
                for(int j = 0;j < listCategory.Length; j++)
                {
                    if (productHaveCategoryName[i].categoryId == listCategory[j].id)
                    {
                        productHaveCategoryName[i].categoryName = listCategory[j].name;
                    }
                }
            }
            return productHaveCategoryName;
        }
        static void printMenu(Menu[] menus)
        {


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
            product[8] = new Product { name = "Case", price = 120, quality = 28, categoryId = 5  };

            Category[] category = new Category[4];
            category[0] = new Category { name = "Comuter", id = 1 };
            category[1] = new Category { name = "Memory", id = 2 };
            category[2] = new Category { name = "Card", id = 3 };
            category[3] = new Category { name = "Acesory", id = 4 };

            Menu[] menu = new Menu[8];
            menu[0] = new Menu { id = 1, title = "Thể thao",parent_id = 0 };
            menu[1] = new Menu { id = 2, title = "Xã hội", parent_id = 0 };
            menu[2] = new Menu { id = 3, title = "Thể thao trong nước", parent_id = 1 };
            menu[3] = new Menu { id = 4, title = "Giao thông", parent_id = 2 };
            menu[4] = new Menu { id = 5, title = "Môi Trường", parent_id=2 };
            menu[5] = new Menu { id = 6, title = "Thể thao quốc tế", parent_id = 1 };
            menu[6] = new Menu { id = 7, title = "Môi trường đô thị", parent_id = 5 };
            menu[7] = new Menu { id = 8, title = "Giao thông ùn tắc", parent_id = 4 };

            /*  Product productTest = new Product();
              productTest = findProduct(product, "RAM");
              Console.WriteLine("name = " +productTest.name);
              Console.WriteLine("price = " +productTest.price);
              Console.WriteLine("quality = " +productTest.quality);
              Console.WriteLine("categoryId = " +productTest.categoryId);

             // findProductByCategory(product, 2);

              for(int j = 0;j < (findProductByCategory(product, 2).Length); j++)
               {
                Console.WriteLine(findProductByCategory(product, 2)[j].name);
                }

              for(int i = 0; i < findProductByPrice(product, 200).Length; i++)
              {
                  Console.WriteLine(findProductByPrice(product, 200)[i].price);
              }
            for(int i = 0; i < sortByPrice(product).Length; i++)
              {
                  Console.WriteLine(sortByPrice(product)[i].price);
                  Console.WriteLine(sortByPrice(product)[i].name);
              }
            for(int i = 0; i< sortByName(product).Length; i++)
              {
                  Console.WriteLine(sortByName(product)[i].name);
              }
            //Console.WriteLine(minByPrice(product).price);
            //Console.WriteLine(maxByPrice(product).price);
            float money, month;
            Console.WriteLine("emter money: ");
            money = float.Parse(Console.ReadLine());
            Console.WriteLine("enter month: ");
            month = float.Parse(Console.ReadLine());
            Console.WriteLine(calSalary(money, month));
            float money, month;
            Console.WriteLine("emter money: ");
            money = float.Parse(Console.ReadLine());
            Console.WriteLine("enter month: ");
            month = float.Parse(Console.ReadLine());
            Console.WriteLine(calSalaryBasic(money, month));
            //Console.WriteLine(callMonthBasic(1000, 10));
            for (int i = 0; i < sortByName(product).Length; i++)
            {
                Console.WriteLine(sortByName(product)[i].name);
            }
            */
            /*for(int i = 0;i < product.Length; i++)
            {
                Console.WriteLine(sortByCategoryName(product, category)[i].name + "   " + sortByCategoryName(product, category)[i].categoryId);
            }*/
            /*mapProductByCategory(product, category);
            for(int i = 0; i < product.Length; i++)
            {
                Console.Write(mapProductByCategory(product, category)[i].name + "    " + mapProductByCategory(product, category)[i].categoryName + "\n");
            }*/
        }
    } 
}