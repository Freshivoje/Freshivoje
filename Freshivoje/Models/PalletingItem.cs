using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freshivoje.Models
{
    public class PalletingItem
    {
        public int _fk_client_id { get; private set; }
        public string _first_name { get; private set; }
        public string _last_name { get; private set; }
        public int _fk_receipt_id { get; private set; }
        public int _fk_article_id { get; private set; }
        public decimal _quantity { get; private set; }
        public string _status { get; private set; }
        public string _article_name { get; private set; }
        public string _sort { get; private set; }
        public string _organic { get; private set; }
        public string _category { get; private set; }

        public PalletingItem(int fk_client_id,
            string first_name,
            string last_name,
            int fk_receipt_id,
            int fk_article_id,
            decimal quantity,
            string status,
            string article_name,
            string sort,
            string organic,
            string category
            )
        {
            _fk_client_id = fk_client_id;
            _first_name = first_name;
            _last_name = last_name;
            _fk_receipt_id = fk_receipt_id;
            _fk_article_id = fk_article_id;
            _quantity = quantity;
            _status = status;
            _article_name = article_name;
            _sort = sort;
            _organic = organic;
            _category = category;

        }
    }
}
