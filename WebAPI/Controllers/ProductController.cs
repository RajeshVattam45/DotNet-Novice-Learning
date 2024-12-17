using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        // Displaying Products.
        private static readonly List<string> Products = new List<string>
        {
        "Laptop", "Tablet", "Smartphone"
        };

        // GET: api/product
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(Products);
        }

        // GET: api/product/1
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            if (id < 0 || id >= Products.Count)
                return NotFound("Product not found");

            return Ok(Products[id]);
        }
    }
}
