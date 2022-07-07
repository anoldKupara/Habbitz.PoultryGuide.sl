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
    public class GetBirdCategoryListRequestHandler : IRequestHandler<GetBirdCategoryListRequest, List<BirdCategoryDto>>
    {
        private readonly IBirdCategoryRepository _birdCategoryRepository;
        private readonly IMapper _mapper;

        public GetBirdCategoryListRequestHandler(IBirdCategoryRepository birdCategoryRepository, IMapper mapper)
        {
            _birdCategoryRepository = birdCategoryRepository;
            _mapper = mapper;
        }
        public async Task<List<BirdCategoryDto>> Handle(GetBirdCategoryListRequest request, CancellationToken cancellationToken)
        {
            var birdCategories = await _birdCategoryRepository.GetAll();
            return _mapper.Map<List<BirdCategoryDto>>(birdCategories);
        }
    }
}
