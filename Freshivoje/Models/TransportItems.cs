using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freshivoje.Models
{
    public class TransportItems
    {
        public int _id { get; private set; }
        public int _clientId { get; private set; }
        public decimal _price { get; private set; }
        public decimal _quantity { get; private set; }
        public decimal _traveled { get; private set; }
        public decimal _totalPrice { get; private set; }

        public TransportItems
            (
            int fkClientId,
            decimal price,
            decimal quantity,
            decimal traveled,
            decimal totalPrice = 0,
            int id = 0
            )
        {
            _id = id;
            _clientId = fkClientId;
            _price = price;
            _quantity = quantity;
            _traveled = traveled;
            _totalPrice = totalPrice;
        }
                            
    }
}
