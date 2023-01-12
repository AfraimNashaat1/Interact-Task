using ProductSearch.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSearch.BusinessLogicLayer.Interfaces
{
    public interface IProduct
    {
        //List<Product> GetProducts(string SearchItem);
        List<Product> GetProducts();

    }
}
