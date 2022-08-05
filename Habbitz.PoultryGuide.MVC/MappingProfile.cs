using Habbitz.PoultryGuide.Application.DTOs.Feeds;
using AutoMapper;
using Habbitz.PoultryGuide.MVC.Models;

namespace Habbitz.PoultryGuide.MVC
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateFeedDto, CreateFeedVM>().ReverseMap();
        }
    }
}
