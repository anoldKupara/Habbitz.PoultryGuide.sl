using Habbitz.PoultryGuide.Application.DTOs.BirdCategories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.BirdCategories.Requests.Queries
{
    public class GetBirdCategoryDetailRequest : IRequest<BirdCategoryDto>
    {
        public int Id { get; set; } 
    }
}
