using AutoMapper;
using Habbitz.PoultryGuide.Application.Features.BirdCategories.Requests.Commands;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using Habbitz.PoultryGuide.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.BirdCategories.Handlers.Commands
{
    public class CreateBirdCategoryCommandHandler : IRequestHandler<CreateBirdCategoryCommand, int>
    {
        private readonly IBirdCategoryRepository _birdCategoryRepository;
        private readonly IMapper _mapper;

        public CreateBirdCategoryCommandHandler(IBirdCategoryRepository birdCategoryRepository, IMapper mapper)
        {
            _birdCategoryRepository = birdCategoryRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateBirdCategoryCommand request, CancellationToken cancellationToken)
        {
            var birdCategory = _mapper.Map<BirdCategory>(request.BirdCategoryDto);
            birdCategory = await _birdCategoryRepository.Add(birdCategory);
            return birdCategory.Id;
        }
    }
}
