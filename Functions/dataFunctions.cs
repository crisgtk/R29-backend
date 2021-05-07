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
                data = varGlobal.sql.ExecuteSqlQuery("execute iacoapp.[data_insert] @description,@id_user,@latitude,@longitude,@interval,@header,@speed,@accuracy,@altitude,@altitudeAccuracy", var, varGlobal.DataBase);

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

        public DataTable dataDeleteDetail(dataModel _data)
        {
            string[,] var = {
                {"id", _data.ID.ToString()}
            };
            return varGlobal.sql.ExecuteSqlQuery("execute iacoapp.[data_remove] @id", var, varGlobal.DataBase);
        }
        public DataTable dataDeleteDescription(string id_usuario, string description)
        {
            string[,] var = {
                {"id_user", id_usuario.ToString()},
                {"description",description.ToString()}
            };
            return varGlobal.sql.ExecuteSqlQuery("execute iacoapp.[data_removeDescription] @id_user,@description", var, varGlobal.DataBase);
        }

        public DataTable getData(string user)
        {
            string[,] var = {
                {"suer", user.ToString()}
            };
            return varGlobal.sql.ExecuteSqlQuery("execute [iacoapp].[search_data]  @user", var, varGlobal.DataBase);
        }

        public DataTable getDataDescription(string id_user)
        {
            string[,] var = {
                {"id_user", id_user.ToString()}
            };
            return varGlobal.sql.ExecuteSqlQuery("execute [iacoapp].[search_data_description]  @id_user", var, varGlobal.DataBase);
        }

        public DataTable getDataListforUser(string id_user,string description)
        {
            string[,] var = {
                {"id_user", id_user.ToString()},
                {"description", description.ToString()}
            };
            return varGlobal.sql.ExecuteSqlQuery("execute [iacoapp].[data_listForUser]  @id_user,@description", var, varGlobal.DataBase);
        }
        public DataTable shareData(string id_usuario, string rutas)
        {
            string[,] var = {
                {"id_usuario", id_usuario.ToString()},
                {"ruta", rutas.ToString()}

            };
            return varGlobal.sql.ExecuteSqlQuery("execute [iacoapp].[share_data]  @id_usuario,@ruta", var, varGlobal.DataBase);
        }

    }
}