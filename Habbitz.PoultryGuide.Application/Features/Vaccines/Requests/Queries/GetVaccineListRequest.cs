using Habbitz.PoultryGuide.Application.DTOs.Vaccines;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Vaccines.Requests.Queries
{
    public class GetVaccineListRequest : IRequest<List<VaccineDto>>
    {
    }
}
