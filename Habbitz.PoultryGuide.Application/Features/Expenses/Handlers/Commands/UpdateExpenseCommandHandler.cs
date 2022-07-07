using AutoMapper;
using Habbitz.PoultryGuide.Application.Features.Expenses.Requests.Commands;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Expenses.Handlers.Commands
{
    public class UpdateExpenseCommandHandler : IRequestHandler<UpdateExpenseCommand, Unit>
    {
        private readonly IExpenseRepository _expenseRepository;
        private readonly IMapper _mapper;

        public UpdateExpenseCommandHandler(IExpenseRepository expenseRepository, IMapper mapper)
        {
            _expenseRepository = expenseRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateExpenseCommand request, CancellationToken cancellationToken)
        {
            var expense = await _expenseRepository.Get(request.ExpenseDto.Id);
            _mapper.Map(request.ExpenseDto, expense);
            await _expenseRepository.Update(expense);
            return Unit.Value;
        }
    }
}
