using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freshivoje.Models
{
    public class Item
    {
        public Article _art { get; private set; }
        public decimal _quantity { get; private set; }
        public string _owener { get; private set; }
        public string _packageId { get; private set; }
        public string _packageNumber { get; private set; }

        public string _category { get; private set; }

        public Item(
            Article art,
            int quantity,
            string owener,
            string packageId = null,
            string packageNumber = null,
            string category = null
            )
        {
            _art = art;
            _quantity = quantity;
            _owener = owener;
            _packageId = packageId;
            _packageNumber = packageNumber;
            _category = category;

        }
    }
}
