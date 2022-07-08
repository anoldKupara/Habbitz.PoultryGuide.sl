using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using Habbitz.PoultryGuide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Persistence.Repository
{
    public class BirdCategoryRepository : GenericRepository<BirdCategory>, IBirdCategoryRepository
    {
        private readonly HabbitzDbContext _dbContext;
        public BirdCategoryRepository(HabbitzDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
