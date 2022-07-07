using Habbitz.PoultryGuide.Application.DTOs.Feeds;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Feeds.Requests.Commands
{
    public class CreateFeedCommand : IRequest<int>
    {
        public FeedDto FeedDto { get; set; }
    }
}
