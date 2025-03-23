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
        public DataTable getProperties()
        {
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.CYG_properties",null, varGlobal.DataBase);
        }
        public DataTable getPropertyDescriptions()
        {
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.CYG_property_descriptions",null, varGlobal.DataBase);
        }

        public DataTable getLocations()
        {
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.CYG_LocationsProperties",null, varGlobal.DataBase);
        }
           public DataTable ShearchUser(string email, string password)
        {
            string[,] var = {
            {"email", email},
            {"password", password},
            };
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.CYG_user_search @email,@password", var, varGlobal.DataBase);
        }
    }
}