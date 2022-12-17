using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FBLeague.Models
{
    public class FBDbContext : DbContext
    {
        public FBDbContext()

: base("name=conn")

        {

        }

        public DbSet<FBData> Users { get; set; }

    }
}