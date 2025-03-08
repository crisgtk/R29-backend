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

     public class menuController : ControllerBase
    {
        private menuFunction _RefFunction = new menuFunction();

        [HttpGet]
        public Result getMenu()
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.getMenu()));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }

    }
}