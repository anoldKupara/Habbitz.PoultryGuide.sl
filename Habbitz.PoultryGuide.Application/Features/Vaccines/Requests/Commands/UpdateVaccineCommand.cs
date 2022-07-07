using Habbitz.PoultryGuide.Application.DTOs.Vaccines;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Vaccines.Requests.Commands
{
    public class UpdateVaccineCommand : IRequest<Unit>
    {
        public UpdateVaccineDto VaccineDto { get; set; }
    }
}
