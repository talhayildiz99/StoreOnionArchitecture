using StoreOnionArc.Application.Features.CQRS.Commands;
using StoreOnionArc.Application.Interfaces;
using StoreOnionArc.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreOnionArc.Application.Features.CQRS.Handlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;

        public UpdateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCategoryCommand command)
        {
            var value = await _repository.GetByIdAsync(command.CategoryId);
            value.CategoryName = command.CategoryName;
            await _repository.UpdateAsync(value);
        }
    }
}
