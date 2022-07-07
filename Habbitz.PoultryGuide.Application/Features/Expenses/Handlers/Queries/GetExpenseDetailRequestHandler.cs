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
    public class GetExpenseDetailRequestHandler : IRequestHandler<GetExpenseDetailRequest, ExpenseDto>
    {
        private readonly IExpenseRepository _expenseRepository;
        private readonly IMapper _mapper;

        public GetExpenseDetailRequestHandler(IExpenseRepository expenseRepository, IMapper mapper)
        {
            _expenseRepository = expenseRepository;
            _mapper = mapper;
        }
        public async Task<ExpenseDto> Handle(GetExpenseDetailRequest request, CancellationToken cancellationToken)
        {
            var expense = await _expenseRepository.Get(request.Id);
            return _mapper.Map<ExpenseDto>(expense);
        }
    }
}
