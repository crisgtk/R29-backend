using System.Collections.Generic;
using System.Data;
using Models;
using Newtonsoft.Json;
namespace Function
{
    public class pinsFuntcion
    {

        public DataTable pinsInsert(List<pinsModel> _data)
        {

            DataTable data = new DataTable();
            foreach (var item in _data)
            {

                string[,] var = {
            {"ID_PIN", item.ID.ToString()},
            {"id_user", item.id_user.ToString()},
            {"ARRName", item.ARRName.ToString()},
            {"latitude", item.latitude.ToString()},
            {"longitude",item.longitude.ToString()},
            {"type",item.type.ToString()},
            {"description", item.description},
            };
                data = varGlobal.sql.ExecuteSqlQuery("execute crisgtk.[pins_insert] @ID_PIN,@id_user,@ARRName,@latitude,@longitude,@type,@description", var, varGlobal.DataBase);
            }
            return data;
        }


        public DataTable pinsUpdate(List<pinsModel> _data)
        {

            DataTable data = new DataTable();
            foreach (var item in _data)
            {
                string[,] var = {
            {"ID_PIN", item.ID.ToString()},
            {"latitude", item.latitude.ToString()},
            {"longitude",item.longitude.ToString()},
            {"type",item.type.ToString()},
            {"description", item.description},
            {"probabilidad", item.probabilidad.ToString()},
            {"severidad", item.severidad.ToString()},
            {"nivel_riesgo", item.nivel_riesgo.ToString()},


            };
                data = varGlobal.sql.ExecuteSqlQuery("execute crisgtk.pins_update @ID_PIN,@latitude,@longitude,@type,@description,@probabilidad,@severidad,@nivel_riesgo", var, varGlobal.DataBase);
            }
            return data;
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