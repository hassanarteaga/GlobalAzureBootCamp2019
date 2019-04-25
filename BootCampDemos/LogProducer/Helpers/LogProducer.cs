using System;
namespace LogProducer.Helpers
{
    public class LogProducer
    {

        public static Models.LogModel ProduceLogEvent(int seed)
        {
            string[] transactions = new string[] {
            "T0","T1","T2","T3","T4","T5","T6","T7","T8","T9"
            };
            string[] users = new string[] {
            "User0","User1","User2","User3","User4","User5","User6","User7","User8","User9"
            };
            string eventDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Models.LogModel logModel = new Models.LogModel()
            {
                data = Guid.NewGuid().ToString().Split('-'),
                transaction_name = transactions[new Random(seed * seed).Next(0, 10)],
                user = users[new Random(seed * seed).Next(0, 10)],
                log_date = eventDate,
                nlog_date = Convert.ToInt64(eventDate.Replace("-", "").Replace(":", "").Replace(" ", "")),
                severity = new Random().Next(1, 10)

            };
            return logModel;
        }
    }
}
