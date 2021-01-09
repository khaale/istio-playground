using GreeterService;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        private readonly string _name;

        public GreeterService(IOptions<AppOptions> appOptions, ILogger<GreeterService> logger)
        {
            _logger = logger;
            _name = appOptions.Value.Name;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = $"Hello from '{request.Name}' on behalf of '{_name}'!"
            });
        }
    }
}
