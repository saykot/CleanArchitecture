using Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace QueryApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductQueryController : ControllerBase
    {
        private readonly ILogger<ProductQueryController> _logger;

        public ProductQueryController(ILogger<ProductQueryController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult> GetProductById(GetProductByIdQuery query)
        {
            return await Task.FromResult(Ok());
        }
    }
}
