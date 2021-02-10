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
    public class dataControllers : ControllerBase
    {
        private dataFunction _RefFunction = new dataFunction();
        [HttpPost]
        public ActionResult<Result> dataInsert([FromBody] dataModel _dataUsr)
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.dataInsert(_dataUsr)));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult<Result> dataUpdate([FromBody] dataModel _dataUsr)
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.dataUpdate(_dataUsr)));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
              [HttpPost]
        public ActionResult<Result> dataDeleteDetail([FromBody] dataModel _dataUsr)
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.dataDeleteDetail(_dataUsr)));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
    }
}