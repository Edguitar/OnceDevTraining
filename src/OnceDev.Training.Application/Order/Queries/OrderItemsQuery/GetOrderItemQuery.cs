using MediatR;
using OnceDev.Training.Domain;
using OnceDev.Training.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnceDev.Training.Application.Order.Queries
{
    public class GetOrderItemQuery:IRequest<IEnumerable<Domain.Order>>
    {
    }
    public class GetOrderByItem : IRequestHandler<GetOrderItemQuery, IEnumerable<Domain.Order>>
    {
        private readonly IOrderRepository _repository;
        public GetOrderByItem(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Domain.Order>> Handle(GetOrderItemQuery request, CancellationToken cancellationToken)
        {
            return await _repository.ListWithOrderItemsAsync();

        }
    }
}

