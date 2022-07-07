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
    public class GetInventoryListRequestHandler : IRequestHandler<GetInventoryListRequest, List<InventoryDto>>
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IMapper _mapper;

        public GetInventoryListRequestHandler(IInventoryRepository inventoryRepository, IMapper mapper )
        {
            _inventoryRepository = inventoryRepository;
            _mapper = mapper;
        }
        public async Task<List<InventoryDto>> Handle(GetInventoryListRequest request, CancellationToken cancellationToken)
        {
            var inventories = await _inventoryRepository.GetAll();
            return _mapper.Map<List<InventoryDto>>(inventories);
        }
    }
}
