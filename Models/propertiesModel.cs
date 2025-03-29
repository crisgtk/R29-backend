namespace Models
{
    public class PropertyDto
    {
        public string Title { get; set; }
        public string DescriptionDetail { get; set; }
        public string DescriptionDetail2 { get; set; } = "";
        public int Category { get; set; }
        public bool ForRent { get; set; }
        public string Status { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public string YouTubeLink { get; set; }
        public string VirtualTourLink { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Comuna { get; set; }
        public string ShortDescription { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int Rooms { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int YearBuilt { get; set; }
        public bool Features { get; set; } = true;
        public string PhotoLinks { get; set; }
        public string Tags { get; set; } = null;
        public int Sqft { get; set; }
        public int ExecutiveId { get; set; }
    }
}