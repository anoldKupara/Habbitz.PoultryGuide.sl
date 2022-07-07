using AutoMapper;
using Habbitz.PoultryGuide.Application.DTOs.Inventories;
using Habbitz.PoultryGuide.Application.Features.Inventories.Requests.Queries;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Inventories.Handlers.Queries
{
    public class GetInventoryDetailRequestHandler : IRequestHandler<GetInventoryDetailRequest, InventoryDto>
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IMapper _mapper;

        public GetInventoryDetailRequestHandler(IInventoryRepository inventoryRepository, IMapper mapper)
        {
            _inventoryRepository = inventoryRepository;
            _mapper = mapper;
        }
        public async Task<InventoryDto> Handle(GetInventoryDetailRequest request, CancellationToken cancellationToken)
        {
            var inventory = await _inventoryRepository.Get(request.Id);
            return _mapper.Map<InventoryDto>(inventory);
        }
    }
}
