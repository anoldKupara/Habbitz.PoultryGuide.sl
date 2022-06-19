using Habbitz.PoultryGuide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Persistence.Contracts
{
    public interface IExpenseRepository : IGenericRepository<Expense>
    {
    }
}
