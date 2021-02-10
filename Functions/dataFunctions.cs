using System.Collections.Generic;
using System.Data;
using Models;
using Newtonsoft.Json;
namespace Function
{
    public class dataFunction
    {
        public DataTable dataInsert(dataModel _data)
        {
            string[,] var = {
            {"description", _data.description},
            {"id_user", _data.id_user.ToString()},
            {"latitude", _data.latitude.ToString()},
            {"longitude",_data.longitude.ToString()},
            {"interval",_data.interval.ToString()},
            {"header", _data.header.ToString()},
            {"speed", _data.speed.ToString()},
            {"accuracy", _data.accuracy.ToString()},
            {"altitude", _data.altitude.ToString()},
            {"altitudeAccuracy", _data.altitudeAccuracy.ToString()}
            };
            return varGlobal.sql.ExecuteSqlQuery("execute execute iacoapp.[data_insert] @description,@id_user,@latitude,@longitude,@interval,@header,@speed,@accuracy,@altitude,@altitudeAccuracy", var, varGlobal.DataBase);
        }
        public DataTable dataUpdate(dataModel _data)
        {
            string[,] var = {
            {"id", _data.ID.ToString()},
            {"description", _data.description},
            {"id_user", _data.id_user.ToString()},
            {"latitude", _data.latitude.ToString()},
            {"longitude",_data.longitude.ToString()},
            {"interval",_data.interval.ToString()},
            {"header", _data.header.ToString()},
            {"speed", _data.speed.ToString()},
            {"accuracy", _data.accuracy.ToString()},
            {"altitude", _data.altitude.ToString()},
            {"altitudeAccuracy", _data.altitudeAccuracy.ToString()}
            };
            return varGlobal.sql.ExecuteSqlQuery("execute execute iacoapp.[data_update] @id,@description,@id_user,@latitude,@longitude,@interval,@header,@speed,@accuracy,@altitude,@altitudeAccuracy", var, varGlobal.DataBase);
        }

        public DataTable dataDeleteDetail(dataModel _data){
            string[,] var = {
                {"id", _data.ID.ToString()}
            };
             return varGlobal.sql.ExecuteSqlQuery("execute execute iacoapp.[data_remove] @id", var, varGlobal.DataBase);
        }
              public DataTable dataDeleteDescription(dataModel _data){
            string[,] var = {
                {"description", _data.description.ToString()}
            };
             return varGlobal.sql.ExecuteSqlQuery("execute execute iacoapp.[data_removeDescription] @description", var, varGlobal.DataBase);
        }

    }
}