using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    class Order
    {
        public String Address;
        public int pincode;
        public String name;
        public int pno;

        public   String Orderlist(String Addr,int pcode, String Name, int Pno)
        {
            Address = Addr;
            pincode = pcode;

            name = Name;
            pno = Pno;
            return Address + "\n" + pincode + "\n" + name + "\n" + pno;
        }

    }
}

