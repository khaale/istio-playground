using GreeterService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingController
    {
        private readonly Greeter.GreeterClient _greeterClient;
        private readonly string _name;

        public GreetingController(IOptions<AppOptions> appOptions, Greeter.GreeterClient greeterClient)
        {
            _name = appOptions.Value.Name;
            _greeterClient = greeterClient;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            var grpcRequest = new HelloRequest
            {
                Name = _name
            };
            var grpcResponse = await _greeterClient.SayHelloAsync(grpcRequest);
            return grpcResponse.Message;
        }
    }
}
