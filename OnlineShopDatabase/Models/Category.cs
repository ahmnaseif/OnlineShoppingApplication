using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShopDatabase.Models
{
    public class Category
    {

        public int Id { get; set; }
        public String CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}