using Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CommandApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductCommandController : ControllerBase
    {
        private readonly ILogger<ProductCommandController> _logger;
        private readonly IMediator _mediator;

        public ProductCommandController(ILogger<ProductCommandController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> AddProductCommand([FromBody] AddProductCommand command, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(command, cancellationToken);
            if(response.Status == 1)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
