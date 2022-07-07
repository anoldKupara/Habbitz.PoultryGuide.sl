using AutoMapper;
using Habbitz.PoultryGuide.Application.Features.Inventories.Requests.Commands;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Inventories.Handlers.Commands
{
    public class UpdateInventoryCommandHandler : IRequestHandler<UpdateInventoryCommand, Unit>
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IMapper _mapper;

        public UpdateInventoryCommandHandler(IInventoryRepository inventoryRepository, IMapper mapper)
        {
            _inventoryRepository = inventoryRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateInventoryCommand request, CancellationToken cancellationToken)
        {
            var inventory = await _inventoryRepository.Get(request.InventoryDto.Id);
            _mapper.Map(request.InventoryDto, inventory);
            await _inventoryRepository.Update(inventory);
            return Unit.Value;
        }
    }
}
