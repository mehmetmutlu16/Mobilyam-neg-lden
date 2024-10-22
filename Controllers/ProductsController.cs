using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mobilyaminegolden.Dtos.ProductDtos;
using Mobilyaminegolden.Entities;
using Mobilyaminegolden.Services.ProductServices;

namespace Mobilyaminegolden.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService ProductService)
        {
            _productService = ProductService;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productService.GetAllProductAsync();
            return Ok(values);
        }

        [HttpGet("category/{categoryId}")]
        public async Task<IActionResult> ProductByCategoryList(int categoryId)
        {
            var values = await _productService.GetAllProductByCategoryAsync(categoryId);
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(string id)
        {
            var values = await _productService.GetByIdProductAsync(id);
            return Ok(values);
        }


        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productService.CreateProductAsync(createProductDto);
            var productId = createProductDto.ProductId;
            return Ok(new { Message = "Ürün detayı başarıyla oluşturuldu.", ProductId = productId });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return Ok("Ürün detayı başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _productService.UpdateProductAsync(updateProductDto);
            return Ok("Ürün detayı başarıyla güncellendi.");
        }
    }
}
