using System;
using System.Data;
using Models;
using System.Globalization;

namespace Function
{
    public class propertiesFunction
    {
        public DataTable InsertProperty(PropertyDto property)
        {
            string[,] parameters = {
                {"@Title", property.Title},
                {"@DescriptionDetail", property.DescriptionDetail},
                {"@DescriptionDetail2", property.DescriptionDetail2},
                {"@Category", property.Category.ToString()},
                {"@ForRent", property.ForRent ? "1" : "0"},
                {"@Status", property.Status},
                {"@Price", property.Price},
                {"@Image", property.Image},
                {"@YouTubeLink", property.YouTubeLink},
                {"@VirtualTourLink", property.VirtualTourLink},
                {"@Address", property.Address},
                {"@Country", property.Country},
                {"@City", property.City},
                {"@Comuna", property.Comuna},
                {"@ShortDescription", property.ShortDescription},
                {"@Latitude", property.Latitude.ToString("G", CultureInfo.InvariantCulture)},
                {"@Longitude", property.Longitude.ToString("G", CultureInfo.InvariantCulture)},
                {"@Rooms", property.Rooms.ToString()},
                {"@Bedrooms", property.Bedrooms.ToString()},
                {"@Bathrooms", property.Bathrooms.ToString()},
                {"@YearBuilt", property.YearBuilt.ToString()},
                {"@Features", property.Features ? "1" : "0"},
                {"@PhotoLinks", property.PhotoLinks},
                {"@Tags", property.Tags},
                {"@sqft", property.Sqft.ToString()},
                {"@executiveId", property.ExecutiveId.ToString()}
            };

            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.CYG_insert_property @Title,@DescriptionDetail,@DescriptionDetail2,@Category,@ForRent,@Status,@Price,@Image,@YouTubeLink,@VirtualTourLink,@Address,@Country,@City,@Comuna,@ShortDescription,@Latitude,@Longitude,@Rooms,@Bedrooms,@Bathrooms,@YearBuilt,@Features,@PhotoLinks,@Tags,@sqft,@executiveId", parameters, varGlobal.DataBase);
        }

        public DataTable UpdateProperty(PropertyDto property)
        {
            string[,] parameters = {
                {"@PropertyId", property.PropertyId.ToString()}, // Asegúrate de que PropertyDto tenga un campo Id
                {"@Title", property.Title},
                {"@DescriptionDetail", property.DescriptionDetail},
                {"@DescriptionDetail2", property.DescriptionDetail2},
                {"@Category", property.Category.ToString()},
                {"@ForRent", property.ForRent ? "1" : "0"},
                {"@Status", property.Status},
                {"@Price", property.Price},
                {"@Image", property.Image},
                {"@YouTubeLink", property.YouTubeLink},
                {"@VirtualTourLink", property.VirtualTourLink},
                {"@Address", property.Address},
                {"@Country", property.Country},
                {"@City", property.City},
                {"@Comuna", property.Comuna},
                {"@ShortDescription", property.ShortDescription},
                {"@Latitude", property.Latitude.ToString("G", CultureInfo.InvariantCulture)},
                {"@Longitude", property.Longitude.ToString("G", CultureInfo.InvariantCulture)},
                {"@Rooms", property.Rooms.ToString()},
                {"@Bedrooms", property.Bedrooms.ToString()},
                {"@Bathrooms", property.Bathrooms.ToString()},
                {"@YearBuilt", property.YearBuilt.ToString()},
                {"@Features", property.Features ? "1" : "0"},
                {"@PhotoLinks", property.PhotoLinks},
                {"@Tags", property.Tags},
                {"@sqft", property.Sqft.ToString()},
                {"@executiveId", property.ExecutiveId.ToString()}
            };

            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.CYG_update_property @PropertyId,@Title,@DescriptionDetail,@DescriptionDetail2,@Category,@ForRent,@Status,@Price,@Image,@YouTubeLink,@VirtualTourLink,@Address,@Country,@City,@Comuna,@ShortDescription,@Latitude,@Longitude,@Rooms,@Bedrooms,@Bathrooms,@YearBuilt,@Features,@PhotoLinks,@Tags,@sqft,@executiveId", parameters, varGlobal.DataBase);
        }

        public DataTable updateStatusProperty(string id, string status)
        {
            System.Diagnostics.Debug.WriteLine("This is a log");
            string[,] var = {
            {"id", id},
            {"status", status},
            };
            return varGlobal.sql.ExecuteSqlQuery("execute crisgtk.CYG_update_properties @id,@status", var, varGlobal.DataBase);
        }
    }
}