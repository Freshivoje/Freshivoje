using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freshivoje.Models
{
    public class Pallete
    {
        public int _id { get; private set; }
        public int _number { get; private set; }

        public Pallete(int palleteId,
            int palleteNumber)
        {
            _id = palleteId;
            _number = palleteNumber;
        }
    }
}
