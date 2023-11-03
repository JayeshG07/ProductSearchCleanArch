using AutoMapper;
using Search.Domain.Dto;
using Search.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Domain.Configuration
{
    public class MapConfig:Profile
    {
        public MapConfig() 
        {
            CreateMap<Product,ProductDto>().ReverseMap();        
        }
    }
}
