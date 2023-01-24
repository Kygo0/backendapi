using NobelBackend.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NobelBackend.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IPrizeRepository Prizes { get; set; }

        ILaureateRepository Laureates { get; set; }


        int Complete();
    }
}