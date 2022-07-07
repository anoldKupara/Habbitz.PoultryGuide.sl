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
    public class GetFeedListRequestHandler : IRequestHandler<GetFeedListRequest, List<FeedDto>>
    {
        private readonly IFeedRepository _feedRepository;
        private readonly IMapper _mapper;

        public GetFeedListRequestHandler(IFeedRepository feedRepository, IMapper mapper)
        {
            _feedRepository = feedRepository;
            _mapper = mapper;
        }
        public async Task<List<FeedDto>> Handle(GetFeedListRequest request, CancellationToken cancellationToken)
        {
            var feeds = await _feedRepository.GetAll();
            return _mapper.Map<List<FeedDto>>(feeds);
        }
    }
}
