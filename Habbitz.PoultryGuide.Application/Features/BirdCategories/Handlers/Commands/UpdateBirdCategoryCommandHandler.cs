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
    public class UpdateBirdCategoryCommandHandler : IRequestHandler<UpdateBirdCategoryCommand, Unit>
    {
        private readonly IBirdCategoryRepository _birdCategoryRepository;
        private readonly IMapper _mapper;

        public UpdateBirdCategoryCommandHandler(IBirdCategoryRepository birdCategoryRepository, IMapper mapper)
        {
            _birdCategoryRepository = birdCategoryRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateBirdCategoryCommand request, CancellationToken cancellationToken)
        {
            var birdCategory = await _birdCategoryRepository.Get(request.BirdCategoryDto.Id);
            _mapper.Map(request.BirdCategoryDto, birdCategory);
            await _birdCategoryRepository.Update(birdCategory);
            return Unit.Value;
        }
    }
}
