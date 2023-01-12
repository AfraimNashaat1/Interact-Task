using System;

namespace ProductSearchDemo.APILayer.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public int SKU { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
    }
}
