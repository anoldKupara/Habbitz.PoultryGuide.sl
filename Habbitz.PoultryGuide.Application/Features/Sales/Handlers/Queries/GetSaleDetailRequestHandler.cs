using AutoMapper;
using Habbitz.PoultryGuide.Application.DTOs.Sales;
using Habbitz.PoultryGuide.Application.Features.Sales.Requests.Queries;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Sales.Handlers.Queries
{
    public class GetSaleDetailRequestHandler : IRequestHandler<GetSaleDetailRequest, SaleDto>
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IMapper _mapper;

        public GetSaleDetailRequestHandler(ISaleRepository saleRepository, IMapper mapper)
        {
            _saleRepository = saleRepository;
            _mapper = mapper;
        }
        public async Task<SaleDto> Handle(GetSaleDetailRequest request, CancellationToken cancellationToken)
        {
            var sale = await _saleRepository.Get(request.Id);
            return _mapper.Map<SaleDto>(sale);
        }
    }
}
