using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using Habbitz.PoultryGuide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Persistence.Repository
{
    public class ExpenseRepository : GenericRepository<Expense>, IExpenseRepository
    {
        private readonly HabbitzDbContext _dbContext;
        public ExpenseRepository(HabbitzDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
