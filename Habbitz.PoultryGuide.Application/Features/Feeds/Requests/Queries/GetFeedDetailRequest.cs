using Habbitz.PoultryGuide.Application.DTOs.Feeds;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Feeds.Requests.Queries
{
    public class GetFeedDetailRequest : IRequest<FeedDto>
    {
        public int Id { get; set; }
    }
}