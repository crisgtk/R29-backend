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

            {"latitude", _data.latitude.ToString()},
            {"longitude",_data.longitude.ToString()},
            {"type",_data.type.ToString()},
            {"description", _data.description},


            };
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.[pins_insert] @latitude,@longitude,@type,@description", var, varGlobal.DataBase);
        }

        public DataTable pinsUpdate(pinsModel _data)
        {
            string[,] var = {
            {"id", _data.ID.ToString()},
            {"latitude", _data.latitude.ToString()},
            {"longitude",_data.longitude.ToString()},
            {"type",_data.type.ToString()},
            {"description", _data.description},


            };
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.pins_update @id,@latitude,@longitude,@type,@description", var, varGlobal.DataBase);
        }
        public DataTable pinsRemove(pinsModel _data)
        {
            string[,] var = {
            {"id", _data.ID.ToString()}
            };
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.[pins_remove] @id", var, varGlobal.DataBase);
        }
        public DataTable listPins()
        {
            return varGlobal.sql.ExecuteSqlQuery("execute [crisgtk].[search_pins]", null, varGlobal.DataBase);
        }
    }
}