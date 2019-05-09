using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace CompanyFunction
{
    public static class QueueFnVSCode
    {
        [FunctionName("QueueFnVSCode")]
        public static void Run([QueueTrigger("myqueue-fromvscode", Connection = "azurebootcampmexico2019_STORAGE")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
