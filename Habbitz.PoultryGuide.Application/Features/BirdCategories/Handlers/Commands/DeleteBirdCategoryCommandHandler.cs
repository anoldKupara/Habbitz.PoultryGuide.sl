using AutoMapper;
using Habbitz.PoultryGuide.Application.Features.BirdCategories.Requests.Commands;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.BirdCategories.Handlers.Commands
{
    public class DeleteBirdCategoryCommandHandler : IRequestHandler<DeleteBirdCategoryCommand>
    {
        private readonly IBirdCategoryRepository _birdCategoryRepository;
        private readonly IMapper _mapper;

        public DeleteBirdCategoryCommandHandler(IBirdCategoryRepository birdCategoryRepository, IMapper mapper)
        {
            _birdCategoryRepository = birdCategoryRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteBirdCategoryCommand request, CancellationToken cancellationToken)
        {
            var birdCategory = await _birdCategoryRepository.Get(request.Id);
            await _birdCategoryRepository.Delete(birdCategory);
            return Unit.Value;
        }
    }
}
