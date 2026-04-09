using AutoMapper;
using GeekShopping.CartAPI.Data.ValueObjects;
using GeekShopping.CartAPI.Model;
using Microsoft.Extensions.Logging.Abstractions;

namespace GeekShopping.CartAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Product, ProductVO>().ReverseMap();
                config.CreateMap<CartHeader, CartHeaderVO>().ReverseMap();
                config.CreateMap<CartDetail, CartDetailVO>().ReverseMap();
                config.CreateMap<Cart, CartVO>().ReverseMap();

            }, NullLoggerFactory.Instance);
            return mappingConfig;
        }
    }
}
