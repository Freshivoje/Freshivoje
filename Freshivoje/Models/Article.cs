using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freshivoje.Models
{
    public  class Article
    {
        public int _id { get; private set; }
        public string _name { get; private set; }
        public string _sort { get; private set; }
        public string _category { get; private set; }
        public string _organic { get; private set; }
        public decimal _priceI { get; private set; }
        public decimal _priceII { get; private set; }
        public decimal _priceIII { get; private set; }
        public decimal _quantity { get; private set; }


        public Article(int articleId, 
            string articleName, 
            string articleSort,
            string category,
            string organic, 
            decimal priceI = 1,
            decimal priceII = 1,
            decimal priceIII = 1,
            decimal quantity = 0)
        {
            _id = articleId;
            _name = articleName;
            _sort = articleSort;
            _category = category;
            _organic = organic;
            _priceI = priceI;
            _priceII = priceII;
            _priceIII = priceIII;
            _quantity = quantity;  
        }

        public void setId(int id)
        {
            _id = id;
        } 
    }
}
