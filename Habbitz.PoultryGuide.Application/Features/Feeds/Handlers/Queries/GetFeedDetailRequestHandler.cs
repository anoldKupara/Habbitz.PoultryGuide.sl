using AutoMapper;
using Habbitz.PoultryGuide.Application.DTOs.Feeds;
using Habbitz.PoultryGuide.Application.Features.Feeds.Requests.Queries;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Feeds.Handlers.Queries
{
    public class GetFeedDetailRequestHandler : IRequestHandler<GetFeedDetailRequest, FeedDto>
    {
        private readonly IFeedRepository _feedRepository;
        private readonly IMapper _mapper;

        public GetFeedDetailRequestHandler(IFeedRepository feedRepository, IMapper mapper)
        {
            _feedRepository = feedRepository;
            _mapper = mapper;
        }
        public async Task<FeedDto> Handle(GetFeedDetailRequest request, CancellationToken cancellationToken)
        {
            var feed = await _feedRepository.Get(request.Id);
            return _mapper.Map<FeedDto>(feed);
        }
    }
}
