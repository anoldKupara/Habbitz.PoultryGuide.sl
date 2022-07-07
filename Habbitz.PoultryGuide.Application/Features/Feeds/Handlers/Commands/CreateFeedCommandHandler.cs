using AutoMapper;
using Habbitz.PoultryGuide.Application.Features.Feeds.Requests.Commands;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using Habbitz.PoultryGuide.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Feeds.Handlers.Commands
{
    public class CreateFeedCommandHandler : IRequestHandler<CreateFeedCommand, int>
    {
        private readonly IFeedRepository _feedRepository;
        private readonly IMapper _mapper;

        public CreateFeedCommandHandler(IFeedRepository feedRepository, IMapper mapper)
        {
            _feedRepository = feedRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateFeedCommand request, CancellationToken cancellationToken)
        {
            var feed = _mapper.Map<Feed>(request.FeedDto);
            feed = await _feedRepository.Add(feed);
            return feed.Id;
        }
    }
}
