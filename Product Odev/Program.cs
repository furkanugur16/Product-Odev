using System;

namespace Product_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productName = "Akıllı Telefon";
            product1.productPrice = 8500;


            Product product2 = new Product();
            product2.productName = "Akıllı Saat";
            product2.productPrice = 4200;

            Product[] productList = new Product[] { product1, product2 };

            //foreach döngüsü ile yazdırma
            Console.WriteLine("Foreach ile yazma -->");
            foreach (var products in productList)
            {
                Console.WriteLine("Ürün Adı:" + products.productName +  " Ürün Fiyatı:" + products.productPrice);
            }



            //for döngüsü ile yazdırma
            Console.WriteLine("For ile yazma -->");
            for (int i = 0; i < productList.Length; i++)
            {
                Console.WriteLine("Ürün Adı: " + productList[i].productName + " Ürün Fiyatı:" + productList[i].productPrice);
            }



            //while ile yazdırma 
            Console.WriteLine("while ile yazma -->");
            int p = 0;
            while (p<productList.Length)
            {
                Console.WriteLine("Ürün Adı:" + productList[p] + " Ürün Fiyatı" + productList[p].productPrice);
                p++;
            }

            

            


        }
    }

    class Product
    {
        public string productName { get; set; }
        public int productPrice { get; set; }
    }
        
}
