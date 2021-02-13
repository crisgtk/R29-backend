using System.Collections.Generic;
using System.Data;
using Models;
using Newtonsoft.Json;
namespace Function
{
    public class dataFunction
    {
        public DataTable dataInsert(List<dataModel> _data)
        {
            DataTable data = new DataTable();
            foreach (var item in _data)
            {
                
           
            string[,] var = {
            {"description", item.description},
            {"id_user", item.id_user.ToString()},
            {"latitude", item.latitude.ToString()},
            {"longitude",item.longitude.ToString()},
            {"interval",item.interval.ToString()},
            {"header", item.header.ToString()},
            {"speed", item.speed.ToString()},
            {"accuracy", item.accuracy.ToString()},
            {"altitude", item.altitude.ToString()},
            {"altitudeAccuracy", item.altitudeAccuracy.ToString()}
            };
            data= varGlobal.sql.ExecuteSqlQuery("execute iacoapp.[data_insert] @description,@id_user,@latitude,@longitude,@interval,@header,@speed,@accuracy,@altitude,@altitudeAccuracy", var, varGlobal.DataBase);
        
         }
         return data;
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
            return varGlobal.sql.ExecuteSqlQuery("execute iacoapp.[data_update] @id,@description,@id_user,@latitude,@longitude,@interval,@header,@speed,@accuracy,@altitude,@altitudeAccuracy", var, varGlobal.DataBase);
        }

        public DataTable dataDeleteDetail(dataModel _data){
            string[,] var = {
                {"id", _data.ID.ToString()}
            };
             return varGlobal.sql.ExecuteSqlQuery("execute iacoapp.[data_remove] @id", var, varGlobal.DataBase);
        }
              public DataTable dataDeleteDescription(dataModel _data){
            string[,] var = {
                {"description", _data.description.ToString()}
            };
             return varGlobal.sql.ExecuteSqlQuery("execute iacoapp.[data_removeDescription] @description", var, varGlobal.DataBase);
        }

        public DataTable getData()
        {
            return varGlobal.sql.ExecuteSqlQuery("execute [iacoapp].[search_data]", null, varGlobal.DataBase);
        }

    }
}