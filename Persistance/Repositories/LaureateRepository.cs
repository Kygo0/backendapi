using NobelBackend.Core.Repositories;
using NobelBackend.Models;
using NobelBackend.MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NobelBackend.Persistance.Repositories
{
    public class LaureateRepository : GenericRepository<Laureate>, ILaureateRepository
    {

        public LaureateRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}