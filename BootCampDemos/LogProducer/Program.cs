using System;
using Newtonsoft.Json;

namespace LogProducer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sending Messages To Queues...");
            for (int i = 0; i < 10; i++)
            {
                string strLog = JsonConvert.SerializeObject(Helpers.LogProducer.ProduceLogEvent(i + 1));
                Helpers.QueueManager.SendMessageToQueue("queuelog1", strLog);
                Helpers.QueueManager.SendMessageToQueue("queuelog2", strLog);
                Console.WriteLine($"Sending Message Queue: {strLog}");
            }
            Console.WriteLine("Finished...");
            Console.ReadKey();
        }
    }
}
