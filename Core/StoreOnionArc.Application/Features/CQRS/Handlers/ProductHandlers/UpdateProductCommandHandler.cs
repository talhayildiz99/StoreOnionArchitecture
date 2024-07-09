using StoreOnionArc.Application.Features.CQRS.Commands.ProductCommands;
using StoreOnionArc.Application.Interfaces;
using StoreOnionArc.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreOnionArc.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler
    {
        private readonly IRepository<Product> _repository;

        public UpdateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateProductCommand command)
        {
            var value = await _repository.GetByIdAsync(command.ProductId);
            value.Stock = command.Stock;
            value.Price = command.Price;
            value.CategoryId = command.CategoryId;
            value.Name = command.Name;
            await _repository.UpdateAsync(value);
        }
    }
}
