using System;
using System.Collections.Generic;
using System.Data;
using Models;
using Newtonsoft.Json;

namespace Function
{
    public class galeryFuncion
    {
          public DataTable GetGalery(string id)
        {
            string[,] var = {
            {"id", id},
            };
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.get_galery @id", var, varGlobal.DataBase);
        }

    }
}