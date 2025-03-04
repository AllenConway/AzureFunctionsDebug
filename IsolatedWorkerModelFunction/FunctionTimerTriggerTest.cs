using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace IsolatedWorkerModelFunction
{
    public class FunctionTimerTriggerTest
    {
        private readonly ILogger _logger;

        public FunctionTimerTriggerTest(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<FunctionTimerTriggerTest>();
        }

        [Function("FunctionTimerTriggerTest")]
        public void Run([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer)
        {
            _logger.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            
            if (myTimer.ScheduleStatus is not null)
            {
                _logger.LogInformation($"Next timer schedule at: {myTimer.ScheduleStatus.Next}");
            }
        }
    }
}
