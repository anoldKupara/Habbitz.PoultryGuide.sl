using AutoMapper;
using Habbitz.PoultryGuide.Application.DTOs.Expenses;
using Habbitz.PoultryGuide.Application.Features.Expenses.Requests.Queries;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Expenses.Handlers.Queries
{
    public class GetExpenseListRequestHandler : IRequestHandler<GetExpenseListRequest, List<ExpenseDto>>
    {
        private readonly IExpenseRepository _expenseRepository;
        private readonly IMapper _mapper;

        public GetExpenseListRequestHandler(IExpenseRepository expenseRepository, IMapper mapper)
        {
            _expenseRepository = expenseRepository;
            _mapper = mapper;
        }
        public async Task<List<ExpenseDto>> Handle(GetExpenseListRequest request, CancellationToken cancellationToken)
        {
            var expenses = await _expenseRepository.GetAll();
            return _mapper.Map<List<ExpenseDto>>(expenses);
        }
    }
}
