﻿using System;
using System.Collections.Generic;

namespace Log1Producer.Models
{
    public class LogModel
    {
        public LogModel()
        {
        }
        public string user { get; set; }
        public string transaction_name { get; set; }
        public int ipseverity { get; set; }
        public string log_date { get; set; }
        public long nlog_date { get; set; }
        public List<string> data { get; set; }
    }
}
