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
    public class GetSaleListRequestHandler : IRequestHandler<GetSaleListRequest, List<SaleDto>>
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IMapper _mapper;

        public GetSaleListRequestHandler(ISaleRepository saleRepository, IMapper mapper)
        {
            _saleRepository = saleRepository;
            _mapper = mapper;
        }
        public async Task<List<SaleDto>> Handle(GetSaleListRequest request, CancellationToken cancellationToken)
        {
            var sales = await _saleRepository.GetAll();
            return _mapper.Map<List<SaleDto>>(sales);
        }
    }
}
