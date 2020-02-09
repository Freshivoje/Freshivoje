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
     
      


        public StorageData(int storageId,
            string storageName
       
          )
        {
            _id = storageId;
            _name = storageName;


        }

        public string getName()
        {
            return _name;
        }

        public void setId(int id)
        {
            _id = id;
        }
    }
}
