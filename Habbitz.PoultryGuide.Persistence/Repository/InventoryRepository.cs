using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using Habbitz.PoultryGuide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Persistence.Repository
{
    public class InventoryRepository : GenericRepository<Inventory>, IInventoryRepository
    {
        private readonly HabbitzDbContext _dbContext;
        public InventoryRepository(HabbitzDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}