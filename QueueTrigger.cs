using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureFunctionsApp
{
    //Queue trigger with blob input binding

    public class QueueTrigger
    {
        [FunctionName("QueueTrigger")]
        public void Run([QueueTrigger("myqueue-items", Connection = "")]string myQueueItem,          //if a new message is added in the queue 'myqueue-items' this will trigger
            [Blob("{blobpath}", FileAccess.Read, Connection = "Yourstorage connection")]
            Stream strrr, ILogger log) 
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
            StreamReader sr = new StreamReader(strrr);
            log.LogInformation($"Length {sr.ReadToEnd().Length} \n Content {sr.ReadToEnd()}");

        }
    }
}
