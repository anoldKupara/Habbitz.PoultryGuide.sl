using Habbitz.PoultryGuide.Application.DTOs.Feeds;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Feeds.Requests.Commands
{
    public class UpdateFeedCommand : IRequest<Unit>
    {
        public UpdateFeedDto FeedDto { get; set; }
    }
}