using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoKartBL;

namespace Productcart
{
    class Program
    {

        //Category c = new Category();
        static void Main(string[] args)
        {
            Category c = new Category();
            Cart cart_main = new Cart();
            int choice_category,i=0;
            Console.WriteLine("Select category : \n");
            Console.WriteLine("1.Electronics\n2.Apparels\n3.Groceries\n4.Cosmetics\n5.View Cart\n0.Exit\n");
            choice_category = Convert.ToInt32(Console.ReadLine());
            while (choice_category!=5 && choice_category!=0)
            {
                
                if (choice_category == 1)
                {
                    foreach (Product p in Category.productList)
                    {
                        if (p.category.categoryId == 1)
                        {
                            Console.WriteLine(p.pid + " " + p.pname + "    " + p.price + "\n");
                        }
                    }
                }
                else if (choice_category == 2)
                {
                    foreach (Product p in Category.productList)
                    {
                        if (p.category.categoryId == 2)
                        {
                            Console.WriteLine(p.pid + " " + p.pname + "    " + p.price + "\n");
                        }
                    }
                }
                else if (choice_category == 3)
                {
                    foreach (Product p in Category.productList)
                    {
                        if (p.category.categoryId == 3)
                        {
                            Console.WriteLine(p.pid + " " + p.pname + "    " + p.price + "\n");
                        }
                    }
                }
                else if (choice_category == 4)
                {
                    foreach (Product p in Category.productList)
                    {
                        if (p.category.categoryId == 4)
                        {
                            Console.WriteLine(p.pid + " " + p.pname + "    " + p.price + "\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input.\n");
                }
                Console.WriteLine("Enter product id to add to cart : \n");
                int input_prodid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter quantity of the product to buy : \n");
                int input_quantity = Convert.ToInt32(Console.ReadLine());
                cart_main.AddToCart(input_prodid, input_quantity);
                Console.WriteLine("Select category : \n");
                Console.WriteLine("1.Electronics\n2.Apparels\n3.Groceries\n4.Cosmetics\n5.View Cart\n0.Exit\n");
                choice_category = Convert.ToInt32(Console.ReadLine());
            }
            if (choice_category == 0)
            {
                Environment.Exit(0);
            }
            else if (choice_category == 5) {
                foreach (Product p in Cart.cartList) {
                    Console.WriteLine("\n"+p.pname +"  " +Cart.quantity[i]+"\n" );
                    i++;
                }
                Console.WriteLine("Your cart total is : "+cart_main.cartTotal);
                Console.WriteLine("\nProceed to checkout? (y/n)\n");
                int checkout_input = Convert.ToInt32(Console.ReadLine());
                if (checkout_input == 1) { 
                    
                }

            }


        }
        
    }
}

