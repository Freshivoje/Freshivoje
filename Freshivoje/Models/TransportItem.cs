namespace Freshivoje.Models
{
    public class TransportItem
    {
        public int _id { get; private set; }
        public int _clientId { get; private set; }
        public decimal _priceSingle { get; private set; }
        public decimal _quantity { get; private set; }
        public decimal _traveled { get; private set; }
        public decimal _price { get; private set; }

        public TransportItem (
            int id,
            int fkClientId,
            decimal price,
            decimal quantity,
            decimal traveled,
            decimal totalPrice = 0
        )
        {
            _id = id;
            _clientId = fkClientId;
            _priceSingle = price;
            _quantity = quantity;
            _traveled = traveled;
            _price = totalPrice;
        }
                            
    }
}
