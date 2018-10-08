using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public class OnlineStoreContext
    {      
            public DbSet<Category> Categories { get; set; }
            public DbSet<Customer> ustomers { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<Purchase> Purchases { get; set; }
            public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        

    }
}