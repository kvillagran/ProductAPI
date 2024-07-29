using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Core.DTOs;
using ProductAPI.Service.Services;
using System.Threading.Tasks;


namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // PUT: api/Product/update-stock
        [HttpPut("update-stock")]
        public async Task<IActionResult> UpdateStock([FromBody] ProductUpdateDto productUpdateDto)
        {
            if (productUpdateDto == null)
            {
                return BadRequest();
            }

            var result = await _productService.UpdateProductStockAsync(productUpdateDto);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}