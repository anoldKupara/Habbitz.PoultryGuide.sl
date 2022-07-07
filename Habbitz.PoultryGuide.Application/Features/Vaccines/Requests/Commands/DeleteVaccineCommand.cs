using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Vaccines.Requests.Commands
{
    public class DeleteVaccineCommand : IRequest
    {
        public int Id { get; set; }
    }
}
