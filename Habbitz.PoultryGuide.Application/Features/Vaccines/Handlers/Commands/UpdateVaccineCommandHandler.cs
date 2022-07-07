using AutoMapper;
using Habbitz.PoultryGuide.Application.Features.Vaccines.Requests.Commands;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Vaccines.Handlers.Commands
{
    public class UpdateVaccineCommandHandler : IRequestHandler<UpdateVaccineCommand, Unit>
    {
        private readonly IVaccineRepository _vaccineRepository;
        private readonly IMapper _mapper;

        public UpdateVaccineCommandHandler(IVaccineRepository vaccineRepository, IMapper mapper)
        {
            _vaccineRepository = vaccineRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateVaccineCommand request, CancellationToken cancellationToken)
        {
            var vaccine = await _vaccineRepository.Get(request.VaccineDto.Id);
            _mapper.Map(request.VaccineDto, vaccine);
            await _vaccineRepository.Update(vaccine);
            return Unit.Value;
        }
    }
}
