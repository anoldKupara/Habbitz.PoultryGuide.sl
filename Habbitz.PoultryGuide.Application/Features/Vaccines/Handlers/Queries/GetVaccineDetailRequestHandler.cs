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
    public class GetVaccineDetailRequestHandler : IRequestHandler<GetVaccineDetailRequest, VaccineDto>
    {
        private readonly IVaccineRepository _vaccineRepository;
        private readonly IMapper _mapper;

        public GetVaccineDetailRequestHandler(IVaccineRepository vaccineRepository, IMapper mapper)
        {
            _vaccineRepository = vaccineRepository;
            _mapper = mapper;
        }
        public async Task<VaccineDto> Handle(GetVaccineDetailRequest request, CancellationToken cancellationToken)
        {
            var vaccine = await _vaccineRepository.Get(request.Id);
            return _mapper.Map<VaccineDto>(vaccine);
        }
    }
}
