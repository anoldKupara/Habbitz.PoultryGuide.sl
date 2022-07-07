using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Expenses.Requests.Commands
{
    public class DeleteExpenseCommand : IRequest
    {
        public int Id { get; set; }
    }
}
