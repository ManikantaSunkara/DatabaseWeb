using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Database.Models;

namespace Database.DAL
{
    public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var categerioes = new List<Categerioes>
            {
                new Categerioes { categoryId = 001, categoryName = "Food", description = "any food item" },
                new Categerioes { categoryId = 002, categoryName = "Furniture", description = "any furniture item" },
                new Categerioes { categoryId = 003, categoryName = "Electronics", description = "any electronics item" },
                new Categerioes { categoryId = 004, categoryName = "Groceries", description = "any groceries item" },
                new Categerioes { categoryId = 005, categoryName = "Books", description = "any books item" },
            };

            categerioes.ForEach(s => context.Categerioes.Add(s));
            context.SaveChanges();

            var orderdetails = new List<OrderDetails>
            {
                new OrderDetails { orderId = 101, productId = 201, unitPrice = 25.00, quantity=1, discount=6 },
                new OrderDetails { orderId = 102, productId = 202, unitPrice = 30.00, quantity=2, discount=7 },
                new OrderDetails { orderId = 103, productId = 203, unitPrice = 35.00, quantity=3, discount=8},
                new OrderDetails { orderId = 104, productId = 204, unitPrice = 35.50, quantity=4, discount=9},
                new OrderDetails { orderId = 105, productId = 205, unitPrice = 36.00, quantity=5, discount=10},
            };

            orderdetails.ForEach(s => context.OrderDetails.Add(s));
            context.SaveChanges();

            var product = new List<Products>
            {
                new Products { productId = 201, productName="biryani", categoryId = 001, supplierId=301, quantityPerLabel=11 },
                new Products { productId = 202, productName="sofa", categoryId = 002, supplierId=302, quantityPerLabel=12},
                new Products { productId = 203, productName="AC", categoryId = 003, supplierId=303, quantityPerLabel=13},
                new Products { productId = 204, productName="sugar", categoryId = 004, supplierId=304, quantityPerLabel=14},
                new Products { productId = 205, productName="novels", categoryId = 005, supplierId=305, quantityPerLabel=15},
            };

            product.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var suppliers = new List<Suppliers>
            {
                new Suppliers { supplierId=301, companyName="paradise",address="vijayawada",postalCode=123456},
                new Suppliers { supplierId=302, companyName="ikea",address="mtm",postalCode=123478},
                new Suppliers { supplierId=303, companyName="sonovision",address="vizag",postalCode=123459},
                new Suppliers { supplierId=304, companyName="more",address="rjy",postalCode=123457},
                new Suppliers { supplierId=305, companyName="publishers",address="vuy",postalCode=123453},
            };

            suppliers.ForEach(s => context.Suppliers.Add(s));
            context.SaveChanges();



        }
    }
}