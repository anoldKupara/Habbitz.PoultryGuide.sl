using AutoMapper;
using Habbitz.PoultryGuide.Application.Features.Feeds.Requests.Commands;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Feeds.Handlers.Commands
{
    public class DeleteFeedCommandHandler : IRequestHandler<DeleteFeedCommand>
    {
        private readonly IFeedRepository _feedRepository;
        private readonly IMapper _mapper;

        public DeleteFeedCommandHandler(IFeedRepository feedRepository, IMapper mapper)
        {
            _feedRepository = feedRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteFeedCommand request, CancellationToken cancellationToken)
        {
            var feed = await _feedRepository.Get(request.Id);
            await _feedRepository.Delete(feed);
            return Unit.Value;
        }
    }
}
