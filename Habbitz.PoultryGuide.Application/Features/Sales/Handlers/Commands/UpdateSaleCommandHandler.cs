using AutoMapper;
using Habbitz.PoultryGuide.Application.Features.Sales.Requests.Commands;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Sales.Handlers.Commands
{
    public class UpdateSaleCommandHandler : IRequestHandler<UpdateSaleCommand, Unit>
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IMapper _mapper;

        public UpdateSaleCommandHandler(ISaleRepository saleRepository, IMapper mapper)
        {
            _saleRepository = saleRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateSaleCommand request, CancellationToken cancellationToken)
        {
            var sale = await _saleRepository.Get(request.SaleDto.Id);
            _mapper.Map(request.SaleDto, sale);
            await _saleRepository.Update(sale);
            return Unit.Value;
        }
    }
}
