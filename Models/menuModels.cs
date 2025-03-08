using System.Linq;
using System.Net;
using System;

namespace Models

{
  public class SubMenuItem
    {
        public string Label { get; set; }
        public string Href { get; set; }
    }

    public class PropertyItem
    {
        public string Label { get; set; }
        //public List<SubMenuItem> SubMenuItems { get; set; }
    }

}