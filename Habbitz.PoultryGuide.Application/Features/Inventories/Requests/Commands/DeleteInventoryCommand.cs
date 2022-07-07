using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Inventories.Requests.Commands
{
    public class DeleteInventoryCommand : IRequest
    {
        public int Id { get; set; }
    }
}
