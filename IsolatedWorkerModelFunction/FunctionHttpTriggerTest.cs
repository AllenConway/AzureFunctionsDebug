using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IsolatedWorkedModelFunction
{
    public class FunctionHttpTriggerTest
    {
        private readonly ILogger<FunctionHttpTriggerTest> _logger;

        public FunctionHttpTriggerTest(ILogger<FunctionHttpTriggerTest> logger)
        {
            _logger = logger;
        }

        [Function("FunctionHttpTriggerTest")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
