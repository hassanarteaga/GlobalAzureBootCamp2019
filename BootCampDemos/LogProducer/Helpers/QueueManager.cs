using System;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Queue;

namespace LogProducer.Helpers
{
    public class QueueManager
    {
        public static void SendMessageToQueue(string queue_name, string queue_message)
        {
            CloudStorageAccount storageAccount;
            storageAccount = CloudStorageAccount.Parse($"DefaultEndpointsProtocol=https;AccountName={StorageAccountConfig.myStorageAccount};AccountKey={StorageAccountConfig.myStorageAccountKey};");
            CloudQueueClient queueClient;
            queueClient = storageAccount.CreateCloudQueueClient();
            CloudQueue queue = queueClient.GetQueueReference(queue_name);
            CloudQueueMessage message = new CloudQueueMessage(queue_message);
            queue.AddMessage(message);

        }
    }
}
