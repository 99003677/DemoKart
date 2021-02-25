using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class Category
    {
        static List<Product> productList = new List<Product>();
        private int categoryId;
        private string categoryName;

        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }

        //static List<Product> garmentList = new List<Product>();
        //static List<Product> groceryList = new List<Product>();
        //static List<Product> cosmeticList = new List<Product>();
        public Category(){
            //List<Product> electronicsList = new List<Product>();
            productList.Add(new Product(1,100,"Trimmer",800));
            productList.Add(new Product(1, 101,"Washing Machine",6000));
            productList.Add(new Product(1, 102,"Earphone",1200));
            productList.Add(new Product(1, 103,"Tubelight",150));
            productList.Add(new Product(1, 104,"Pen Drive 64GB",929));
            //List<Product> garmentList = new List<Product>();
            productList.Add(new Product(2,200,"Black Joggers for men",1300));
            productList.Add(new Product(2, 201,"Floral Dress for women",1600));
            productList.Add(new Product(2, 202,"Unisex white tshirt",350));
            productList.Add(new Product(2, 203,"Formal Shirt Blue for men",1000));
            productList.Add(new Product(2, 204,"Black knee length skirt for women",1300));
            //List<Product> groceryList = new List<Product>();
            productList.Add(new Product(3,300,"Gram Pulse 2kg",200));
            productList.Add(new Product(3, 301,"Rice Basmati 3kg",500));
            productList.Add(new Product(3, 302,"Garam Masala 1kg",475));
            productList.Add(new Product(3, 303,"Wheat Flour 10kg",600));
            productList.Add(new Product(3, 304,"Fine Flour 5kg",500));
            //List<Product> cosmeticList = new List<Product>();
            productList.Add(new Product(4,400, "Eyeliner", 300));
            productList.Add(new Product(4, 401, "Concealer", 450));
            productList.Add(new Product(4, 402, "Eye shadow pallet", 600));
            productList.Add(new Product(4, 403, "Nailpaint Nude white", 250));
            productList.Add(new Product(4, 404, "Lip gloss cherry", 350));
        }

    }
}
