using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.BirdCategories.Requests.Commands
{
    public class DeleteBirdCategoryCommand : IRequest
    {
        public int Id { get; set; } 
    }
}
