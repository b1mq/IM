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

        public int BasketId { get; set; }
        public Basket Basket { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public bool IsPaid { get; set; }
        public bool IsRefunded { get; set; }
        public string PaymentMethod { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
