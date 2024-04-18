using Application.Commands;
using Domain.Utilities;
using MediatR;

namespace Application.Handlers
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, Response>
    {
        public AddProductCommandHandler() 
        { 
        
        }

        public async Task<Response> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
