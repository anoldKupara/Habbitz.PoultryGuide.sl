using Habbitz.PoultryGuide.Application.DTOs.Expenses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Expenses.Requests.Commands
{
    public class CreateExpenseCommand : IRequest<int>
    {
        public ExpenseDto ExpenseDto { get; set; }
    }
}
