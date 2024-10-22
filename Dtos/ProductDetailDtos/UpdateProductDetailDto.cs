namespace Mobilyaminegolden.Dtos.ProductDetailDtos
{
    public class UpdateProductDetailDto
    {
        public string ProductDetailId { get; set; }
        public string ProductDetailName { get; set; }
        public string ProductDetailPrice { get; set; }
        public List<string> ProductDetailImages { get; set; }
        public List<string> ProductDetailSizes { get; set; }
        public List<string> ProductDetailTable { get; set; }
        public List<string> ProductDetailPrices { get; set; }
        public string Kartela { get; set; }
        public string ProductId { get; set; }
    }
}
