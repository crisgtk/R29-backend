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
        public DataTable getProperties(string executiveId, string idProperty)
            {
            string query = "execute crisgtk.CYG_properties";
            List<string[]> paramList = new List<string[]>();

            if (!string.IsNullOrEmpty(executiveId))
            {
                query += " @executiveId";
                paramList.Add(new string[] { "executiveId", executiveId });
            }

            if (!string.IsNullOrEmpty(idProperty))
            {
                if (!query.Contains("@executiveId"))
                    query += " @idProperty";
                else
                    query += ",@idProperty";
                paramList.Add(new string[] { "idProperty", idProperty });
            }

            string[,] parameters = null;
            if (paramList.Count > 0)
            {
                parameters = new string[paramList.Count, 2];
                for (int i = 0; i < paramList.Count; i++)
                {
                    parameters[i, 0] = paramList[i][0];
                    parameters[i, 1] = paramList[i][1];
                }
            }

            return varGlobal.sql.ExecuteSqlQuery(query, parameters, varGlobal.DataBase);
        }
        public DataTable getPropertyDescriptions()
        {
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.CYG_property_descriptions",null, varGlobal.DataBase);
        }
        public DataTable getPropertyForSlice()
        {
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.CYG_properties_slider",null, varGlobal.DataBase);
        }
         public DataTable getPropertyForCities()
        {
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.CYG_properties_for_cities",null, varGlobal.DataBase);
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