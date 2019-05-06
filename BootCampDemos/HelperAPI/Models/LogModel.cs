using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HelperAPI.Models
{
    public class LogModel
    {
        public LogModel()
        {
        }
        public string user { get; set; }
        public string transaction_name { get; set; }
        public int severity { get; set; }
        public string log_date { get; set; }
        public long nlog_date { get; set; }
        public string[] data { get; set; }


    }

    public class ValidationModel
    {
        public ValidationModel()
        {

        }
        [Required(ErrorMessage = "Object Type  is required")]
        public string ObjType { get; set; }
        [StringLength(5)]
        public string ObjBehavior { get; set; }
    }
}
