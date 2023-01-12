using AutoMapper;
using ProductSearch.DataAccessLayer.Models;
using ProductSearchDemo.APILayer.DTOs;

namespace ProductSearchDemo.APILayer.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ProductDTO, Product>().ReverseMap();
                  
        }
    }
}
