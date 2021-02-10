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
    public class pinsControllers : ControllerBase
    {
        private pinsFuntcion _RefFunction = new pinsFuntcion();
        [HttpPost]
        public ActionResult<Result> pinsInsert([FromBody] pinsModel _dataPins)
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.pinsInsert(_dataPins)));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult<Result> pinsUpdate([FromBody] pinsModel _dataPins)
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.pinsUpdate(_dataPins)));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult<Result> pinsRemove([FromBody] pinsModel _dataPins)
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.pinsRemove(_dataPins)));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
    }
}