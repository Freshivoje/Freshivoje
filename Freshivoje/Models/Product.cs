using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freshivoje.Models
{
    public class Product
    {
        public int _id { get; private set; }

        public string _name { get; private set; }
        public string _type { get; private set; }
        public Product(int id, string name, string type)
        {
            _id = id;
            _name = name;
            _type = type;
        }
    }
}
