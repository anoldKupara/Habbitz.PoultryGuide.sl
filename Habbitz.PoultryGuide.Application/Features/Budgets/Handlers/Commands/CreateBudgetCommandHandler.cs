using AutoMapper;
using Habbitz.PoultryGuide.Application.Features.Budgets.Requests.Commands;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using Habbitz.PoultryGuide.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Budgets.Handlers.Commands
{
    public class CreateBudgetCommandHandler : IRequestHandler<CreateBudgetCommand, int>
    {
        private readonly IBudgetRepository _budgetRepository;
        private readonly IMapper _mapper;

        public CreateBudgetCommandHandler(IBudgetRepository budgetRepository, IMapper mapper)
        {
            _budgetRepository = budgetRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateBudgetCommand request, CancellationToken cancellationToken)
        {
            var budget = _mapper.Map<Budget>(request.BudgetDto);
            budget = await _budgetRepository.Add(budget);
            return budget.Id;
        }
    }
}
