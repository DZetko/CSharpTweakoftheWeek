using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeIndexers
{
    class Program
    {
        static void Main(string[] args)
        {
            UserList userList = new UserList();

            userList.Add(new User(1, "Daniel"));
            userList.Add(new User(2, "Martin"));
            userList.Add(new User(3, "Stewie"));

            var user = userList["Stewie"];

            Console.WriteLine($"Name: {user.Name}, id: {user.Id}");
            Console.ReadLine();
        }
    }
}
