using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freshivoje.Models
{
    public class PurchaseArticles
    {

        public List<int> clients = new List<int>();
        public List<Item> articles = new List<Item>();

        public PurchaseArticles() { }



        public void setClient(int id)
        {
            clients.Add(id);
        }

        public void removeClient(int id)
        {
            clients.Remove(id);
        }


        public void setArticle(Item art)
        {
            articles.Add(art);
        }

        public void removeArticle(Item art)
        {
            articles.Remove(art);
        }


    }
}
