﻿namespace Mobilyaminegolden.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
