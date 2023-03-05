using System.Collections.Generic;
using System.Data;
using Models;
using Newtonsoft.Json;
namespace Function
{
    public class pinsFuntcion
    {

        public DataTable pinsInsert(pinsModel _data)
        {
            string[,] var = {
            {"ID_PIN", _data.ID.ToString()},
            {"id_user", _data.id_user.ToString()},
            {"ARRName", _data.ARRName.ToString()},
            {"latitude", _data.latitude.ToString()},
            {"longitude",_data.longitude.ToString()},
            {"type",_data.type.ToString()},
            {"description", _data.description},


            };
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.[pins_insert] @ID_PIN,@id_user,@ARRName,@latitude,@longitude,@type,@description", var, varGlobal.DataBase);
        }

        public DataTable pinsUpdate(pinsModel _data)
        {
            string[,] var = {
            {"ID_PIN", _data.ID.ToString()},
            {"latitude", _data.latitude.ToString()},
            {"longitude",_data.longitude.ToString()},
            {"type",_data.type.ToString()},
            {"description", _data.description},
            {"probabilidad", _data.probabilidad.ToString()},
            {"severidad", _data.severidad.ToString()},
            {"nivel_riesgo", _data.nivel_riesgo.ToString()},


            };
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.pins_update @ID_PIN,@latitude,@longitude,@type,@description,@probabilidad,@severidad,@nivel_riesgo", var, varGlobal.DataBase);
        }
        public DataTable pinsRemove(pinsModel _data)
        {
            string[,] var = {
            {"ID_PIN", _data.ID.ToString()}
            };
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.[pins_remove] @ID_PIN", var, varGlobal.DataBase);
        }
        public DataTable listPins()
        {
            return varGlobal.sql.ExecuteSqlQuery("execute [crisgtk].[search_pins]", null, varGlobal.DataBase);
        }

        public DataTable listUserPins(pinsModel _data)
        {
            string[,] var = {
            {"ID_PIN", _data.ID.ToString()},
            {"id_user", _data.id_user.ToString()},
            {"ARRName",_data.@ARRName.ToString()},
            };

            return varGlobal.sql.ExecuteSqlQuery("execute [crisgtk].[search_user_pins] @ID_PIN,@id_user,@ARRName", null, varGlobal.DataBase);
        }
    }
}