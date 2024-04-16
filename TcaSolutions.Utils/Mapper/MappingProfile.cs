using AutoMapper;
using TcaSolutions.Entities;
using TcaSolutions.Shared.DTOs;
using TcaSolutions.Shared.ViewModels;
using TcaSolutions.Shared.ViewModels.Product;

namespace TcaSolutions.Utils.Mapper
{
    public static class MappingProfile
    {
        public static IMapper InitializeAutoMapper()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Login, LoginDTO>().ReverseMap();
                cfg.CreateMap<LoginViewModel, LoginDTO>();

                cfg.CreateMap<Product, ProductDTO>().ReverseMap();
                cfg.CreateMap<ProductDTO, ProductViewModel>();
                cfg.CreateMap<ProductCreateViewModel, ProductDTO>();
                cfg.CreateMap<ProductUpdateViewModel, ProductDTO>();
            });


            return mapperConfiguration.CreateMapper();
        }
    }
}

