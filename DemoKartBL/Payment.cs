using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    class Payment
    {
        Cart cart  = new Cart();
        int i=1000;
        double res;
        public double finalTotal;
        void PaymentMode(int choice,string cardnumber, string name, string depends_on_choice){
            if (choice == 1)
            {
                res = creditCardPay(cardnumber, name, depends_on_choice);
            }
            else if (choice == 2)
            {
                res = debitCardPay(cardnumber, name, depends_on_choice);
            }
            else { 
                
            }
        }
        double creditCardPay(string cardnumber, string name, string date){
            finalTotal = cart.cartTotal + (cart.cartTotal * 0.1);
            return finalTotal;
        }
        double debitCardPay(string cardnumber, string name, string cvv) {
            finalTotal = cart.cartTotal + (cart.cartTotal * 0.1);
            return finalTotal;
        }
    }
}
