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

        [HttpGet("{id}")]
        public Result getProperties(string id)
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.getProperties(id)));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
          [HttpGet]
        public Result getPropertyDescriptions()
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.getPropertyDescriptions()));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
        [HttpGet]
        public Result getLocations()
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.getLocations()));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
        [HttpGet]
        public Result getPropertyForSlice()
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.getPropertyForSlice()));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
        [HttpGet]
        public Result getPropertyForCities()
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.getPropertyForCities()));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
  
    [HttpPost]
    public ActionResult<Result> ShearchUser([FromBody] UserLoginDto user)
    {
        try
        {
            return Result.Success(JsonConvert.SerializeObject(_RefFunction.ShearchUser(user.email, user.password)));
        }
        catch (Exception ex)
        {
            return Result.Fail(ex.Message);
        }
    }

    }
}