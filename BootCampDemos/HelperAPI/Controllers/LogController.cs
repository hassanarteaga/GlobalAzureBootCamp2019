using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace HelperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : Controller
    {
        // GET: api/Log
        [HttpGet]
        public List<Models.LogModel> Get()
        {
            List<Models.LogModel> logList = new List<Models.LogModel>();
            for (int i = 0; i < 10; i++)
            {
                Models.LogModel logModel = Helpers.LogProducer.ProduceLogEvent(i + 1);
                string strLog = JsonConvert.SerializeObject(logModel);
                logList.Add(logModel);
                Helpers.QueueManager.SendMessageToQueue("queuelog1", strLog);
                Helpers.QueueManager.SendMessageToQueue("queuelog2", strLog);
            }
            return logList;
        }
    }
}
