using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Feeds.Requests.Commands
{
    public class DeleteFeedCommand : IRequest
    {
        public int Id { get; set; }
    }
}
