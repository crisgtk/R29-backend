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
        public DataTable getProperties(string id)
        {
            string query = "execute crisgtk.CYG_properties";
            string[,] parameters = null;

            if (!string.IsNullOrEmpty(id))
            {
                query += " @executiveId";
                parameters = new string[,] { { "executiveId", id } };
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