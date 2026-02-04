using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.Domain
{
    public class PromoCode
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public decimal DiscountValue { get; set; } 
        public bool IsPercent { get; set; }
    }
}
