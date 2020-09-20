using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ShopMediator.Domain.Commands.Requests;
using ShopMediator.Domain.Commands.Response;

namespace ShopMediator.Domain.Handlers
{
    public class CreateCustomerHandler : 
    IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {

        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // verifica se o clinete ja esta cadastrado
            // valida os dados
            // insere o cliente
            // envia email de boas vindas
            var result = new CreateCustomerResponse{
                Id = Guid.NewGuid(),
                Name = "Matheus Bertho",
                Email = "matheus.berthot@gmail.com",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}