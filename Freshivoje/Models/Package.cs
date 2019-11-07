using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freshivoje.Models
{
    public class Package
    {
        public int _id { get; private set; }
        public int _capacity { get; private set; }
        public decimal _price { get; private set; }
        public int _packageFkCategoryId { get; private set; }
        public int _quantity { get; private set; }

        public Package(int packageId,
            int packageCapacity,
            decimal packagePrice,
            int packageFkCategoryId,
            int packageQuantity
        )
        {
            _id = packageId;
            _capacity = packageCapacity;
            _price = packagePrice;
            _packageFkCategoryId = packageFkCategoryId;
            _quantity = packageQuantity;
        }

    }
}
