using Microsoft.AspNetCore.Mvc;

namespace TeaBag.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public async Task<IActionResult> CreateProduct()
        {
            return Ok();
        }
    }
}
