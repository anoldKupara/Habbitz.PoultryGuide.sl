using AutoMapper;
using Habbitz.PoultryGuide.Application.DTOs.BirdCategories;
using Habbitz.PoultryGuide.Application.Features.BirdCategories.Requests.Queries;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.BirdCategories.Handlers.Queries
{
    public class GetBirdCategoryDetailRequestHandler : IRequestHandler<GetBirdCategoryDetailRequest, BirdCategoryDto>
    {
        private readonly IBirdCategoryRepository _birdCategoryRepository;
        private readonly IMapper _mapper;

        public GetBirdCategoryDetailRequestHandler(IBirdCategoryRepository birdCategoryRepository, IMapper mapper)
        {
            _birdCategoryRepository = birdCategoryRepository;
            _mapper = mapper;
        }
        public async Task<BirdCategoryDto> Handle(GetBirdCategoryDetailRequest request, CancellationToken cancellationToken)
        {
            var birdCategory = await _birdCategoryRepository.Get(request.Id);
            return _mapper.Map<BirdCategoryDto>(birdCategory);
        }
    }
}
