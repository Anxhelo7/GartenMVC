using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace garten.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=cns")
        {

        }

        public DbSet<kindergarten> kindergartens { get; set; }

    }
}