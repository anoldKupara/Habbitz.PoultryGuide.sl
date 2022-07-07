using Habbitz.PoultryGuide.Application.DTOs.Expenses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Expenses.Requests.Queries
{
    public class GetExpenseListRequest : IRequest<List<ExpenseDto>>
    {
    }
}
