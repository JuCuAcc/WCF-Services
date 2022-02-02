using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace MyHWcfService.Models
{
    public class MyContext : DbContext
    {
        public MyContext() : base("DbCon")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}