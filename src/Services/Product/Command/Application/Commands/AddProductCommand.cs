﻿using Domain.Utilities;
using MediatR;

namespace Application.Commands
{
    public class AddProductCommand : IRequest<Response>
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
