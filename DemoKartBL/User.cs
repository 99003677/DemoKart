
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    class User
    {
        public String username;
        public String password;
        public static List<User> ul = new List<User>();
        public User()
        {

            ul.Add(new User("sri", "sri1234"));
            ul.Add(new User("lekha", "lekha1234"));
            ul.Add(new User("parimi", "parimi1234"));
            ul.Add(new User("yamini", "yamini1234"));

        }
        public User(String name, String pswd)
        {
            this.username = name;
            this.password = pswd;
        }
        public int Authent(String username, String password)
        {
            if (ul.Contains(new User(username, password)))
            {
                return 1;

            }
            else
            {
                ul.Add(new User(username, password));
                return 0;
            }
        }


    }
}

