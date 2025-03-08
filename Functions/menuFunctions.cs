using System;
using System.Collections.Generic;
using System.Data;
using Models;
using Newtonsoft.Json;

namespace Function
{
    public class menuFunction
    {
        public DataTable getMenu()
        {
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.CYG_menu",null, varGlobal.DataBase);
        }
    }
}