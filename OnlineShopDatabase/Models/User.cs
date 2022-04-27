using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShopDatabase.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public String UserName { get; set; }
        public String UserAddress { get; set; }
        public int UserContact { get; set; }
        public String UserMail { get; set; }
        public String UserPass { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}