using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeIndexers
{
    public class UserList : List<User>
    {
        public User this[string name]
        {
            get
            {
                foreach (User user in this)
                {
                    if (user.Name == name)
                    {
                        return user;
                    }
                }

                return null;
            }
        }
    }
}
