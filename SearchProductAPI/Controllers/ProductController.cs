using Microsoft.AspNetCore.Mvc;
using Search.Application.Interfaces;

namespace SearchProductAPI.Controllers
{
    [ApiController]
    public class ProductController : Controller
    {
        public readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet("GetAllProduct")]
        public async Task<JsonResult> GetAllProducts()
        {
            var result = _productRepository.GetAllProducts();
            return Json(result);
        }

        [HttpGet("SearchProduct")]
        public async Task<JsonResult> Search([FromQuery]string content)
        {
            var result = _productRepository.SearchProduct(content);
            return Json(result);
        }
    }
}
