using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using Habbitz.PoultryGuide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Persistence.Repository
{
    public class CurrencyRepository : GenericRepository<Currency>, ICurrencyRepository
    {
        private readonly HabbitzDbContext _dbContext;
        public CurrencyRepository(HabbitzDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
