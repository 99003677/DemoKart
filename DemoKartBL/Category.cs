using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    class Category
    {
        static List<Product> productList = new List<Product>();
        public int categoryId;
        public string categoryName;
        //static List<Product> garmentList = new List<Product>();
        //static List<Product> groceryList = new List<Product>();
        //static List<Product> cosmeticList = new List<Product>();
        public Category(){
            //List<Product> electronicsList = new List<Product>();
            productList.Add(new Product(100,"Trimmer",800));
            productList.Add(new Product(101,"Washing Machine",6000));
            productList.Add(new Product(102,"Earphone",1200));
            productList.Add(new Product(103,"Tubelight",150));
            productList.Add(new Product(104,"Pen Drive 64GB",929));
            //List<Product> garmentList = new List<Product>();
            productList.Add(new Product(200,"Black Joggers for men",1300));
            productList.Add(new Product(201,"Floral Dress for women",1600));
            productList.Add(new Product(202,"Unisex white tshirt",350));
            productList.Add(new Product(203,"Formal Shirt Blue for men",1000));
            productList.Add(new Product(204,"Black knee length skirt for women",1300));
            //List<Product> groceryList = new List<Product>();
            productList.Add(new Product(300,"Gram Pulse 2kg",200));
            productList.Add(new Product(301,"Rice Basmati 3kg",500));
            productList.Add(new Product(302,"Garam Masala 1kg",475));
            productList.Add(new Product(303,"Wheat Flour 10kg",600));
            productList.Add(new Product(304,"Fine Flour 5kg",500));
            //List<Product> cosmeticList = new List<Product>();
            productList.Add(new Product(400, "Eyeliner", 300));
            productList.Add(new Product(401, "Concealer", 450));
            productList.Add(new Product(402, "Eye shadow pallet", 600));
            productList.Add(new Product(403, "Nailpaint Nude white", 250));
            productList.Add(new Product(404, "Lip gloss cherry", 350));
        }

    }
}
