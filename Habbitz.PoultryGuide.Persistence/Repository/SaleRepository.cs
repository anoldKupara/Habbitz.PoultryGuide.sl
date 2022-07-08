using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using Habbitz.PoultryGuide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Persistence.Repository
{
    public class SaleRepository : GenericRepository<Sale>, ISaleRepository
    {
        private readonly HabbitzDbContext _dbContext;
        public SaleRepository(HabbitzDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}