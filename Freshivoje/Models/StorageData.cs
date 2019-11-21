using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freshivoje.Models
{
    class StorageData
    {
        public int _id { get; private set; }
        public string _name { get; private set; }
        public decimal _articleQuantity { get; private set; }
        public decimal _packageQuantity { get; private set; }
      


        public StorageData(int storageId,
            string storageName,
            decimal articleQuantity,
            decimal packageQuantity
          )
        {
            _id = storageId;
            _name = storageName;
            _articleQuantity = articleQuantity;
            _packageQuantity = packageQuantity;

        }

        public void setId(int id)
        {
            _id = id;
        }
    }
}
