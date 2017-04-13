using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeIndexers
{
    public class User
    {
        private int _id;
        private string _name;

        public User(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id => _id;
        public string Name => _name;
    }
}
