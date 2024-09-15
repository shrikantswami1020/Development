using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AZ_204_FunctionsDemo
{
    public class TimerTriggerFunctionDemo
    {
        [FunctionName("TimerTriggerFunctionDemo")]
        public async Task Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Hello Shrikant - Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
