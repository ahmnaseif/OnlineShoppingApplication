using OnlineShopDatabase.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShopDatabase.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public String ProductDescription { get; set; }
        public int CategoryId { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}