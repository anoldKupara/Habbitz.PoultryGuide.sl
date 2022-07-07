using Habbitz.PoultryGuide.Application.DTOs.Inventories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Inventories.Requests.Commands
{
    public class UpdateInventoryCommand : IRequest<Unit>
    {
        public UpdateInventoryDto InventoryDto { get; set; }
    }
}