using NobelBackend.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NobelBackend.MyDatabase
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext() : base("NobelBackendConnection")
        {

        }

        public DbSet<Prize> Prizes { get; set; }
        public DbSet<Laureate> Laureates { get; set; }

     
    }
}