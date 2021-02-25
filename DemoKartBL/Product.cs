using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{

    class Product : Category
    {
        public int pid { get; set; }
        public String pname { get; set; }
        //public int quantity { get; set; }
        public double price { get; set; }

        
        public Product(int categoryid,int pid,String pname,double price)
        {
            this.pid = pid;
            this.pname = pname;
            //this.quantity = quantity;
            this.price = price;
            this.categoryId = categoryid;
        }
        


    }

}

