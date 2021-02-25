using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    
    public class Cart
    {
        static List<Product> cartList = new List<Product>();
        static List<int> quantity = new List<int>();
        public double cartTotal=0;
        Category category = new Category();
        public void AddToCart(Product prod, int quan,int choice)
        {
            cartList.Add(prod);
            quantity.Add(quan);
            if(choice==1){
                cartTotal = cartTotal+(prod.price*quan)+(prod.price*quan*0.18);
            }
            else if(choice==2){
                cartTotal = cartTotal+(prod.price*quan)+(prod.price*quan*0.07);
            }
            else if (choice==3){
                cartTotal = cartTotal+(prod.price*quan)+(prod.price*quan*0.04);
            }
            else if(choice==4){
                cartTotal = cartTotal+(prod.price*quan)+(prod.price*quan*0.18);
            }
            else{
                
            }
        }
        
    }
}
