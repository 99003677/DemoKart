using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{

    public class Product 
    {
        public int pid;
        public string pname;
        //public int quantity { get; set; }
        public double price;
        public Category category;
        //public Product() { }
        

        
        public Product(int categoryid,int pid,string pname,double price)
        {
            category = new Category();
            this.pid = pid;
            this.pname = pname;
            //this.quantity = quantity;
            this.price = price;
            this.category.categoryId = categoryid;
        }
        


    }

}

