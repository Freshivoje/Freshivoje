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
        public string _packageCategory { get; private set; }
        public int _quantity { get; private set; }
        public int _weight { get; private set; }
        public string _producer { get; private set; }
        public string _status { get; private set; }

        public Package(int packageId,
            int packageCapacity,
            decimal packagePrice,
            string packageCategory,
            int packageQuantity,
            int packageWeight,
            string packageProducer,
            string packageStatus
        )
        {
            _id = packageId;
            _capacity = packageCapacity;
            _price = packagePrice;
            _packageCategory = packageCategory;
            _quantity = packageQuantity;
            _weight = packageWeight;
            _producer = packageProducer;
            _status = packageStatus;
        }
    }
}
