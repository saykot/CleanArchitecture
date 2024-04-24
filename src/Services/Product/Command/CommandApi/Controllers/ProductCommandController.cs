using Application.Commands;
using FluentValidation;
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
        private readonly IServiceProvider _serviceProvider;

        public ProductCommandController(ILogger<ProductCommandController> logger, IMediator mediator, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _mediator = mediator;
            _serviceProvider = serviceProvider;
        }

        [HttpPost]
        public async Task<ActionResult> AddProductCommand([FromBody] AddProductCommand command, CancellationToken cancellationToken)
        {
            var validator = _serviceProvider.GetService<IValidator<AddProductCommand>>();
            if(validator != null)
            {
                var validationResult = await validator.ValidateAsync(command, cancellationToken);
                if(!validationResult.IsValid)
                {
                    return BadRequest(validationResult);
                }
            }
            var response = await _mediator.Send(command, cancellationToken);
            if(response.Status == 1)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
