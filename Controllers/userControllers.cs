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
    public class UserController : ControllerBase
    {
        private userFuncion _RefFunction = new userFuncion();

        [HttpGet]
        public Result ListUser()
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.listUser()));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult<Result> insertUser([FromBody] user _listaUsr)
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.insertUser(_listaUsr)));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult<Result> updateUser([FromBody] user _listaUsr)
        {
            try
            {
                return Result.Success(JsonConvert.SerializeObject(_RefFunction.UpadateUser(_listaUsr)));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
        [HttpGet("{user}")]
        public ActionResult<Result> userAtributes(string user)
        {
            try
            {
                return Result.Success(_RefFunction.userAtributes(user));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
        [HttpGet("{user}/{password}")]
        public ActionResult<Result> ShearchUser(string user, string password)
        {
            try
            {
                return Result.Success(_RefFunction.ShearchUser(user, password));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
    }

}