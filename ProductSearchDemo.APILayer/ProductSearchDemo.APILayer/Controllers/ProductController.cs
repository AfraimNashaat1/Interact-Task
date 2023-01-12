using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductSearch.BusinessLogicLayer.Interfaces;
using ProductSearchDemo.APILayer.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductSearchDemo.APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;
        private readonly IMapper _mapper;

        public ProductController(IProduct product, IMapper mapper)
        {
            _product = product;
           _mapper = mapper;
        }
        //[HttpGet]
        //public  ActionResult<List<ProductDTO>> Get(string SearchItem)
        //{
        //    var products =  _product.GetProducts(SearchItem);

        //    return _mapper.Map<List<ProductDTO>>(products);
        //}
        [HttpGet]
        public ActionResult<List<ProductDTO>> Get()
        {
            var products = _product.GetProducts();

            return _mapper.Map<List<ProductDTO>>(products);
        }

    }
}
