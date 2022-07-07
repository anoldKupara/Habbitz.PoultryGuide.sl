using Habbitz.PoultryGuide.Application.DTOs.Budgets;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Budgets.Requests.Commands
{
    public class UpdateBudgetCommand : IRequest<Unit>
    {
        public UpdateBudgetDto BudgetDto { get; set; }
    }
}
