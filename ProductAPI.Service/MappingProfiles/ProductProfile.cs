using AutoMapper;
using ProductAPI.Core.DTOs;
using ProductAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Service.MappingProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductUpdateDto, Product>();
        }
    }
}
