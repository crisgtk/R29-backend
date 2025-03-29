using System.Linq;
using System.Net;
using System;

namespace Models
{
        public class dataModel
    {
        public int ID { get; set; }
        public string description { get; set; }
        public int id_user { get; set; }
        public int id_company { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public DateTimeOffset interval { get; set; }
        public double header { get; set; }
        public double speed { get; set; }
        public double accuracy { get; set; }
        public double altitude { get; set; }
        public double altitudeAccuracy { get; set; }
    }
}
