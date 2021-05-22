using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.DbModels
{
    public class CustomerBasket:BaseEntity
    {
        public CustomerBasket()
        {

        }

        public CustomerBasket(string id)
        {
            Id = id;
        }

        public string Id { get; set; }
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
    }
}
