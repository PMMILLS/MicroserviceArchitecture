using AutoMapper;
using DomainLayer.Models;
using PresentationLayer.Models;

namespace PresentationLayer.Common
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<DomainModel, HomeViewModel>();
        }
    }
}
