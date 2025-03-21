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
    public class GaleryController : ControllerBase
    {

         private galeryFuncion _RefFunction = new galeryFuncion();


        [HttpGet("{id}")]
        public ActionResult<Result> GetGalery(string id)
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.GetGalery(id)));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }

        }
    }
}