using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    
    public class Cart
    {
        public static List<Product> cartList = new List<Product>();
        public static List<int> quantity = new List<int>();
        public double cartTotal=0;
        //Category category = new Category();
        public void AddToCart(int prodid, int quan)
        {
            foreach (Product prod in Program.productList)
            {
                if (prodid==prod.pid) 
                {
                    cartList.Add(prod);
                    quantity.Add(quan);
                    if (prod.category.categoryId == 1)
                    {
                        cartTotal = cartTotal + (prod.price * quan) + (prod.price * quan * 0.18);
                    }
                    else if (prod.category.categoryId == 2)
                    {
                        cartTotal = cartTotal + (prod.price * quan) + (prod.price * quan * 0.07);
                    }
                    else if (prod.category.categoryId == 3)
                    {
                        cartTotal = cartTotal + (prod.price * quan) + (prod.price * quan * 0.04);
                    }
                    else if (prod.category.categoryId == 4)
                    {
                        cartTotal = cartTotal + (prod.price * quan) + (prod.price * quan * 0.18);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            
        }
        
    }
}
