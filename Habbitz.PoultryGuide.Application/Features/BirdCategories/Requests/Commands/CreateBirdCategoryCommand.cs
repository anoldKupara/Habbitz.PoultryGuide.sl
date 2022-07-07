using Habbitz.PoultryGuide.Application.DTOs.BirdCategories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.BirdCategories.Requests.Commands
{
    public class CreateBirdCategoryCommand : IRequest<int>
    {
        public BirdCategoryDto BirdCategoryDto { get; set; }
    }
}

