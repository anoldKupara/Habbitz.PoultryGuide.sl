using AutoMapper;
using Habbitz.PoultryGuide.Application.Exceptions;
using Habbitz.PoultryGuide.Application.Features.Sales.Requests.Commands;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using Habbitz.PoultryGuide.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Sales.Handlers.Commands
{
    public class DeleteSaleCommandHandler : IRequestHandler<DeleteSaleCommand>
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IMapper _mapper;

        public DeleteSaleCommandHandler(ISaleRepository saleRepository, IMapper mapper)
        {
            _saleRepository = saleRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteSaleCommand request, CancellationToken cancellationToken)
        {
            var sale = await _saleRepository.Get(request.Id);

            if (sale == null)
                throw new NotFoundException(nameof(Sale), request.Id);
            else
            {
                await _saleRepository.Delete(sale);
                return Unit.Value;
            }
        }
    }
}
