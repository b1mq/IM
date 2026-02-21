using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.Domain
{
    public class Basket
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public ICollection<BasketItem> Items { get; set; } = new List<BasketItem>();
        public decimal Price { get; set; } // without discount 
        public bool isFreeShipping { get; set; }
        public int? PromocodeId { get; set; }
        public PromoCode PromoCode { get; set; }
        public decimal ShippingPrice {  get; set; }
        public decimal VAT {  get; set; } 
        public decimal TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
