using AutoMapper;
using Mango.Services.OrderAPI.Messages;
using Mango.Services.OrderAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<OrderHeader, CheckoutHeaderDto>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
