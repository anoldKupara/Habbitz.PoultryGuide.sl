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
    public class GetBudgetListRequestHandler : IRequestHandler<GetBudgetListRequest, List<BudgetDto>>
    {
        private readonly IBudgetRepository _budgetRepository;
        private readonly IMapper _mapper;

        public GetBudgetListRequestHandler(IBudgetRepository budgetRepository, IMapper mapper)
        {
            _budgetRepository = budgetRepository;
            _mapper = mapper;
        }
        public async Task<List<BudgetDto>> Handle(GetBudgetListRequest request, CancellationToken cancellationToken)
        {
            var budgets = await _budgetRepository.GetAll();
            return _mapper.Map<List<BudgetDto>>(budgets);
        }
    }
}
