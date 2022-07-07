using AutoMapper;
using Habbitz.PoultryGuide.Application.Features.Budgets.Requests.Commands;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Budgets.Handlers.Commands
{
    public class UpdateBudgetCommandHandler : IRequestHandler<UpdateBudgetCommand, Unit>
    {
        private readonly IBudgetRepository _budgetRepository;
        private readonly IMapper _mapper;

        public UpdateBudgetCommandHandler(IBudgetRepository budgetRepository, IMapper mapper)
        {
            _budgetRepository = budgetRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateBudgetCommand request, CancellationToken cancellationToken)
        {
            var budget = await _budgetRepository.Get(request.BudgetDto.Id);
            _mapper.Map(request.BudgetDto, budget);
            await _budgetRepository.Update(budget);
            return Unit.Value;
        }
    }
}
