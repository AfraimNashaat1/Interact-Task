using ProductSearch.BusinessLogicLayer.Helpers;
using ProductSearch.BusinessLogicLayer.Interfaces;
using ProductSearch.DataAccessLayer.Interfaces;
using ProductSearch.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSearch.BusinessLogicLayer
{
    public class ProductOperation : IProduct
    {
        private readonly IBaseRepository<Product> _repository;

        public ProductOperation(IBaseRepository<Product> repository)
        {
          _repository = repository;
        }
        //public  List<Product> GetProducts(string SearchItem)
        //{
        //   var querable=  _repository.GetAll().Where(c => c.Description.Contains(SearchItem)).AsQueryable();
        //    return querable.Paginate(10,1).ToList();
        //}
        public List<Product> GetProducts()
        {
            var querable = _repository.GetAll().AsQueryable();
            return querable.Paginate(30, 1).ToList();
        }
    }
}
