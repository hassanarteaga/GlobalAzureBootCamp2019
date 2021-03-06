﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using HelperAPI.Models;
using Microsoft.AspNetCore.Mvc;


namespace HelperAPI.Controllers
{
    [Route("api/[controller]")]
    public class ObjectManagerController : Controller
    {

      
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]ValidationModel data)
        {
            if (ModelState.IsValid)
            {
                ValidationModel model = new ValidationModel()
                {
                    ObjType = $"Reloaded-{data.ObjType}",
                    ObjBehavior = $"Reloaded-{data.ObjBehavior}",
                };
                return new OkObjectResult(model);
            }
            else
            {
                return new BadRequestObjectResult(ModelState);
            }
        }
    }
}

