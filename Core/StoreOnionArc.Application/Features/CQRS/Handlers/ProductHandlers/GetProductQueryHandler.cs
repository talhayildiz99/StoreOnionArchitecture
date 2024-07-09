using StoreOnionArc.Application.Features.CQRS.Results.CategoryResults;
using StoreOnionArc.Application.Features.CQRS.Results.ProductResults;
using StoreOnionArc.Application.Interfaces;
using StoreOnionArc.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreOnionArc.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class GetProductQueryHandler
    {
            private readonly IRepository<Product> _repository;

            public GetProductQueryHandler(IRepository<Product> repository)
            {
                _repository = repository;
            }

            public async Task<List<GetProductQueryResult>> Handle()
            {
                var values = await _repository.GetAllAsync();
                return values.Select(x => new GetProductQueryResult
                {
                   ProductId = x.ProductId,
                   CategoryId = x.CategoryId,
                   Name = x.Name,
                   Price = x.Price,
                   Stock = x.Stock
                }).ToList();
            }
        }
    
}
