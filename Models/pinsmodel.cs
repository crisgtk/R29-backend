using System.Linq;
using System.Net;
using System;

namespace Models
{
    public class pinsModel
    {
        public int ID { get; set; }
        public int ID_PIN { get; set; }
        public int id_user { get; set; }
        public string ARRName { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int type { get; set; }
        public string description { get; set; }
        public int probabilidad { get; set; }
        public int severidad { get; set; }
        public int nivel_riesgo { get; set; }
    }
}