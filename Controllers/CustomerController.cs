using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShopMediator.Domain.Commands.Requests;
using ShopMediator.Domain.Commands.Response;
using ShopMediator.Domain.Handlers;

namespace ShopMediator.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {


        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create(
            [FromServices]IMediator mediator,
            [FromBody]CreateCustomerRequest command

        ){
            return mediator.Send(command);
        }

    }
}