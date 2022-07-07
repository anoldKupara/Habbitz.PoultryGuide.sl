using Habbitz.PoultryGuide.Application.DTOs.Expenses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Expenses.Requests.Queries
{
    public class GetExpenseDetailRequest : IRequest<ExpenseDto>
    {
        public int Id { get; set; }
    }
}