using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Database.Models;

namespace Database.DAL
{
    public class Context : DbContext
    {
        public Context() : base("Context")
        {
        }

        public DbSet<Categerioes> Categerioes { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}