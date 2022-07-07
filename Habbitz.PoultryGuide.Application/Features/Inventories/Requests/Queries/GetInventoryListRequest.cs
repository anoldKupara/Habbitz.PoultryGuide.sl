using Habbitz.PoultryGuide.Application.DTOs.Inventories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Inventories.Requests.Queries
{
    public class GetInventoryListRequest : IRequest<List<InventoryDto>>
    {
    }
}
