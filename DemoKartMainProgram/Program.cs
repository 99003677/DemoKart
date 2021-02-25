using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productcart
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int i;
            Product[] p = new Product[100];
            Console.WriteLine("enter username");
            String username = Console.ReadLine();
            Console.WriteLine("enter pasword");
            String password = Console.ReadLine();
            User u = new User();
            int res = u.Authent(username, password);
           

        }
    }
}

