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
        //public static List<Product> productList = new List<Product>();

        static void Main(string[] args)
        {
            try
            {
                
                Product.productList.Add(new Product(1, 100, "Trimmer", 800));
                Product.productList.Add(new Product(1, 101, "Washing Machine", 6000));
                Product.productList.Add(new Product(1, 102, "Earphone", 1200));
                Product.productList.Add(new Product(1, 103, "Tubelight", 150));
                Product.productList.Add(new Product(1, 104, "Pen Drive 64GB", 929));
                
                Product.productList.Add(new Product(2, 200, "Black Joggers for men", 1300));
                Product.productList.Add(new Product(2, 201, "Floral Dress for women", 1600));
                Product.productList.Add(new Product(2, 202, "Unisex white tshirt", 350));
                Product.productList.Add(new Product(2, 203, "Formal Shirt Blue for men", 1000));
                Product.productList.Add(new Product(2, 204, "Black knee length skirt for women", 1300));
                
                Product.productList.Add(new Product(3, 300, "Gram Pulse 2kg", 200));
                Product.productList.Add(new Product(3, 301, "Rice Basmati 3kg", 500));
                Product.productList.Add(new Product(3, 302, "Garam Masala 1kg", 475));
                Product.productList.Add(new Product(3, 303, "Wheat Flour 10kg", 600));
                Product.productList.Add(new Product(3, 304, "Fine Flour 5kg", 500));
                
                Product.productList.Add(new Product(4, 400, "Eyeliner", 300));
                Product.productList.Add(new Product(4, 401, "Concealer", 450));
                Product.productList.Add(new Product(4, 402, "Eye shadow pallet", 600));
                Product.productList.Add(new Product(4, 403, "Nailpaint Nude white", 250));
                Product.productList.Add(new Product(4, 404, "Lip gloss cherry", 350));
                Cart cart_main = new Cart();
                Payment pay = new Payment();
                int choice_category, i = 0;
                Console.WriteLine("Select category : \n");
                Console.WriteLine("1.Electronics\n2.Apparels\n3.Groceries\n4.Cosmetics\n5.View Cart\n0.Exit\n");
                choice_category = Convert.ToInt32(Console.ReadLine());
                while (choice_category != 5 && choice_category != 0)
                {

                    if (choice_category == 1)
                    {
                        foreach (Product p in Product.productList)
                        {
                            if (p.category.categoryId == 1)
                            {
                                Console.WriteLine(p.pid + " " + p.pname + "    " + p.price + "\n");
                            }
                        }
                        //break;
                    }
                    else if (choice_category == 2)
                    {
                        foreach (Product p in Product.productList)
                        {
                            if (p.category.categoryId == 2)
                            {
                                Console.WriteLine(p.pid + " " + p.pname + "    " + p.price + "\n");
                            }
                        }
                        //break;
                    }
                    else if (choice_category == 3)
                    {
                        foreach (Product p in Product.productList)
                        {
                            if (p.category.categoryId == 3)
                            {
                                Console.WriteLine(p.pid + " " + p.pname + "    " + p.price + "\n");
                            }
                        }
                        //break;
                    }
                    else if (choice_category == 4)
                    {
                        foreach (Product p in Product.productList)
                        {
                            if (p.category.categoryId == 4)
                            {
                                Console.WriteLine(p.pid + " " + p.pname + "    " + p.price + "\n");
                            }
                        }
                        //break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input.\n");
                        break;
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
                else if (choice_category == 5)
                {
                    foreach (Product p in Cart.cartList)
                    {
                        Console.WriteLine("\n" + p.pname + "  " + Cart.quantity[i] + "\n");
                        i++;
                    }
                    Console.WriteLine("Your cart total is : " + cart_main.cartTotal);
                    Console.WriteLine("\nProceed to checkout? (1/0)\n");
                    int checkout_input = Convert.ToInt32(Console.ReadLine());
                    if (checkout_input == 1)
                    {
                        Console.WriteLine("1.Credit Card\n2.Debit Card\n");
                        int payment_input = Convert.ToInt32(Console.ReadLine());
                        if (payment_input == 1)
                        {
                            Console.WriteLine("Enter your credit card number : \n");
                            string creditCardNumber = Console.ReadLine();
                            Console.WriteLine("\nEnter card holder name : \n");
                            string cardHolderName = Console.ReadLine();
                            Console.WriteLine("\nEnter expiry date : \n");
                            string expDate = Console.ReadLine();
                            Console.WriteLine("\n" + pay.PaymentMode(payment_input, creditCardNumber, cardHolderName, expDate));
                        }
                        else if (payment_input == 2)
                        {
                            Console.WriteLine("Enter your debit card number : \n");
                            string debitCardNumber = Console.ReadLine();
                            Console.WriteLine("\nEnter card holder name : \n");
                            string cardHolderName = Console.ReadLine();
                            Console.WriteLine("\nEnter expiry date : \n");
                            string cvv = Console.ReadLine();
                            Console.WriteLine("\n" + pay.PaymentMode(payment_input, debitCardNumber, cardHolderName, cvv));
                        }
                    }
                    else
                    {
                        Environment.Exit(0);
                    }

                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            


        }
        
    }
}

