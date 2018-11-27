using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class WebApiDemoContext : DbContext
    {
    
        public WebApiDemoContext() : base("name=WebApiDemoContext")
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
