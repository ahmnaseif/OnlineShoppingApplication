using OnlineShopDatabase.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShopDatabase.Models
{
    public class OrderDetail
    {
        [Key]
        public int OderId { get; set; }
        public int OrderDate { get; set; }
        public int CartId { get; set; }
        public int UserId { get; set; }
        public String PaymentType { get; set; }
        public int Amount { get; set; }
        public int Discount { get; set; }
        public int TotalPayable { get; set; }

        public virtual User User { get; set; }
        public virtual Cart Cart { get; set; }
    }
}