using NobelBackend.Controllers;
using NobelBackend.Core;
using NobelBackend.Core.Repositories;
using NobelBackend.MyDatabase;
using NobelBackend.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NobelBackend.Persistance
{
    public class UnitOfWork : IUnitOfWork

    {
        private ApplicationDbContext context;


        public UnitOfWork(ApplicationDbContext dbContext)
        {
            context = dbContext;
            Prizes = new PrizeRepository(context);
            Laureates = new LaureateRepository(context);
    
            
        }

        public IPrizeRepository Prizes { get; }
        public ILaureateRepository Laureates { get; }
      
        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}