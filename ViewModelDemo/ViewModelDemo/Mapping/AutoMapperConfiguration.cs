using System;
using System.Linq;
using AutoMapper;
using ViewModelDemo.Models;
using ViewModelDemo.ViewModels;

namespace ViewModelDemo.Mapping
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new UserProfile());
            });
        }
    }

    public class UserProfile : Profile
    {
        protected override void Configure()
        {
            // can map by convention as property names match
            Mapper.CreateMap<MappedProductViewModel, Product>();

            // can map explicitly using fluent specification
            // all properties mapped for illustration, actually only really need to specify 
            // price in this example as other properties could be mapped by convention
            Mapper.CreateMap<Product, ProductDetailViewModel>()
                   .ForMember(dest => dest.name,
                    opt => opt.MapFrom(src => src.name))
                   .ForMember(dest => dest.description,
                    opt => opt.MapFrom(src => src.description))
                   .ForMember(dest => dest.price,
                    opt => opt.MapFrom(src => String.Format("{0:c}", src.price)));
        }
    }

}