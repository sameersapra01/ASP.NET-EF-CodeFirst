using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NET_EF_CodeFirst.Models
{
    public class NorthwindCodeFirst: DbContext
    {
        DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasKey(c => c.CustomerID);

            modelBuilder.Entity<Order>()
                .HasKey(c => c.OrderID);
        }
    }
}