using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class OurDbContext : DbContext
    {
        public DbSet<UserAccount> UserAccount { get; set; }

        public OurDbContext() : base("Default")
        {

        }
    }


}