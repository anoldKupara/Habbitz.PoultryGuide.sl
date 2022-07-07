using AutoMapper;
using Habbitz.PoultryGuide.Application.DTOs.Vaccines;
using Habbitz.PoultryGuide.Application.Features.Vaccines.Requests.Queries;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Vaccines.Handlers.Queries
{
    public class GetVaccineListRequestHandler : IRequestHandler<GetVaccineListRequest, List<VaccineDto>>
    {
        private readonly IVaccineRepository _vaccineRepository;
        private readonly IMapper _mapper;

        public GetVaccineListRequestHandler(IVaccineRepository vaccineRepository, IMapper mapper)
        {
            _vaccineRepository = vaccineRepository;
            _mapper = mapper;
        }
        public async Task<List<VaccineDto>> Handle(GetVaccineListRequest request, CancellationToken cancellationToken)
        {
            var vaccines = await _vaccineRepository.GetAll();
            return _mapper.Map<List<VaccineDto>>(vaccines);
        }
    }
}
