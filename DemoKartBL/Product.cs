using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{

    public class Product 
    {
        public int pid { get; set; }
        public string pname { get; set; }
        //public int quantity { get; set; }
        public double price { get; set; }
        public Category category = new Category();
        
        

        
        public Product(int categoryid,int pid,string pname,double price)
        {
            this.pid = pid;
            this.pname = pname;
            //this.quantity = quantity;
            this.price = price;
            this.category.categoryId = categoryid;
        }
        


    }

}

