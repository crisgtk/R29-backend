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
    public class dataController : ControllerBase
    {
        private dataFunction _RefFunction = new dataFunction();

      [HttpGet("{user}")]
        public Result getData(string user)
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.getData(user)));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }

         [HttpGet("{id_user}")]
        public Result getDataDescription(string id_user)
        {
            try
            {
                return Result.Success(_RefFunction.getDataDescription(id_user));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
         [HttpGet("{id_user}/{description}")]
        public Result getDataListforUser(string id_user,string description)
        {
            try
            {
                return Result.Success(_RefFunction.getDataListforUser(id_user,description));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
              [HttpGet("{id_usuario}/{rutas}")]
        public Result shareData(string id_usuario, string rutas )
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.shareData(id_usuario,rutas)));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult<Result> dataInsert([FromBody] List<dataModel> _dataUsr)
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
          [HttpGet("{id_usuario}/{description}")]
        public Result dataDeleteDescription(string id_usuario, string description )
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.dataDeleteDescription(id_usuario,description)));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
    }
}