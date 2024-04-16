using Application.Commands;
using Microsoft.AspNetCore.Mvc;

namespace CommandApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductCommandController : ControllerBase
    {
        private readonly ILogger<ProductCommandController> _logger;

        public ProductCommandController(ILogger<ProductCommandController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult> AddProductCommand(AddProductCommand command)
        {
            return await Task.FromResult(Ok());
        }
    }
}
