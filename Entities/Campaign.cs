using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerDemo.Entities
{
    public class Campaign:IEntity
    {
        public int DiscountRate { get; set; }
        public string DiscountName { get; set; }
        public string DiscountStore { get; set; }
        public int DiscountId { get; set; }
    }
}
