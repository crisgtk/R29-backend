using System;
using System.Collections.Generic;
using System.Data;
using Models;
using Newtonsoft.Json;

namespace Function
{
    public class userFuncion
    {

        public DataTable listUser()
        {
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.user_list", null, varGlobal.DataBase);

        }
        public DataTable userAtributes(string user)
        {
            string[,] var ={
                  {"user",user}
             };
            return varGlobal.sql.ExecuteSqlQuery("execute [crisgtk].[user_atributes] @user", var, varGlobal.DataBase);
        }

        public DataTable insertUser(user _data)
        {
            string[,] var = {
            {"name", _data.Name},
            {"user", _data.User},
            {"password", _data.Password},
            {"email",_data.Email},
            {"telephone",_data.Telephone},
            };
            return varGlobal.sql.ExecuteSqlQuery("execute [crisgtk].[user_insert] @name,@user,@password,@email,@telephone", var, varGlobal.DataBase);
        }

        public DataTable UpadateUser(user _data)
        {
            string[,] var = {
            {"id", _data.ID.ToString()},
            {"name", _data.Name},
            {"user", _data.User},
          //   {"password", _data.Password},
            {"email",_data.Email},
            {"telephone",_data.Telephone},
            {"active",_data.active}
            };
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.user_update @id,@name,@user,@email,@telephone,@active", var, varGlobal.DataBase);
        }


        public DataTable ShearchUser(string user, string password)
        {
            System.Diagnostics.Debug.WriteLine("This is a log");
            string[,] var = {
            {"user", user},
            {"password", password},
            };
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.user_search @user,@password", var, varGlobal.DataBase);
        }
    }

}