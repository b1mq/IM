using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int BasketId { get; set; }
        public ICollection<Basket> Baskets { get; set; } = new List<Basket>();
        public int UserId { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
        public bool isPayed { get; set; }
        public bool isRefunded { get; set; }
        public string PaymentMethod { get; set; }

    }
}
