using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShopDatabase.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int ProductCount { get; set; }
        public int ProductPrice { get; set; }

        public virtual Product Product { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}