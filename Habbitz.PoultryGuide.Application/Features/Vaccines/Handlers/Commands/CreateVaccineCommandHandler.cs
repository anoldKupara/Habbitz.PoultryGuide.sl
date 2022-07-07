using AutoMapper;
using Habbitz.PoultryGuide.Application.Features.Vaccines.Requests.Commands;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using Habbitz.PoultryGuide.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Vaccines.Handlers.Commands
{
    public class CreateVaccineCommandHandler : IRequestHandler<CreateVaccineCommand, int>
    {
        private readonly IVaccineRepository _vaccineRepository;
        private readonly IMapper _mapper;

        public CreateVaccineCommandHandler(IVaccineRepository vaccineRepository, IMapper mapper)
        {
            _vaccineRepository = vaccineRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateVaccineCommand request, CancellationToken cancellationToken)
        {
            var vaccine = _mapper.Map<Vaccine>(request.VaccineDto);
            vaccine = await _vaccineRepository.Add(vaccine);
            return vaccine.Id;
        }
    }
}
