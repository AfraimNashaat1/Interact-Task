using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSearch.DataAccessLayer.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int SKU { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public Decimal Price { get; set; }
    }
}
