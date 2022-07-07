using AutoMapper;
using Habbitz.PoultryGuide.Application.DTOs.Budgets;
using Habbitz.PoultryGuide.Application.Features.Budgets.Requests.Queries;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Budgets.Handlers.Queries
{
    public class GetBudgetDetailRequestHandler : IRequestHandler<GetBudgetDetailRequest, BudgetDto>
    {
        private readonly IBudgetRepository _budgetRepository;
        private readonly IMapper _mapper;

        public GetBudgetDetailRequestHandler(IBudgetRepository budgetRepository, IMapper mapper)
        {
            _budgetRepository = budgetRepository;
            _mapper = mapper;
        }
        public async Task<BudgetDto> Handle(GetBudgetDetailRequest request, CancellationToken cancellationToken)
        {
            var budget = await _budgetRepository.Get(request.Id);
            return _mapper.Map<BudgetDto>(budget);
        }
    }
}
