using AutoMapper;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.Mappings
{
    public class ViewModelToDomainMappiingProfile : Profile
    {
        public ViewModelToDomainMappiingProfile()
        {
            CreateMap<ProductViewModel, Product>();
        }
    }
}
