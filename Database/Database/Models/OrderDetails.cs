using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Database.Models
{
    public class OrderDetails
    {
        public int orderId { get; set; }
        public int productId { get; set; }
        public double unitPrice { get; set; }
        public int quantity { get; set; }

        public int discount { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}