using CRMManager.Application.Features.Customers.Queries.ListAll;
using CRMManager.Domain.Aggregates.CustomerAggregate;
using CRMManager.Domain.Aggregates.CustomerAggregate.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Application.Features.Customers.Queries.ListAll
{
    public class ListAllCustomersQueryHandler : IRequestHandler<ListAllCustomersQuery, List<Customer>>
    {
        private readonly ICustomerRepository _customerRepository;

        public ListAllCustomersQueryHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;


        }

        public async Task<List<Customer>> Handle(ListAllCustomersQuery request, CancellationToken cancellationToken)
        {
            return await _customerRepository.GetAllAsync();
        }
    }
}
