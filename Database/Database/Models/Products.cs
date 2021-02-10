using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Database.Models
{
    public class Products
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public int categoryId { get; set; }
        public int supplierId { get; set; }

        public int quantityPerLabel { get; set; }

        public virtual ICollection<Categerioes> Categerioes { get; set; }
    }
}