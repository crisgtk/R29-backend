using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using Function;
using Models;
using Config;
using System.Linq;
using Newtonsoft.Json;

namespace Controllers
{
    [Route("[controller]/[action]")]
    public class propertiesController : ControllerBase
    {
        private propertiesFunction _RefFunction = new propertiesFunction();

        [HttpPost]
        public ActionResult<Result> InsertProperty([FromBody] PropertyDto property)
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.InsertProperty(property)));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
        [HttpGet("{id}/{status}")]
        public ActionResult<Result> updateStatusProperty(string id, string status)
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.updateStatusProperty(id, status)));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
    }
}