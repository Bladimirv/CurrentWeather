namespace Model
{
    using System.Collections.Generic;

    public partial class CurrentWheather
    {
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }
        //public string base { get; set; }
        public Main main { get; set; }
        public decimal visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public decimal dt { get; set; }
        public Sys sys { get; set; }
        public decimal timezone { get; set; }
        public decimal id { get; set; }
        public string name { get; set; }
        public decimal cod { get; set; }
    }

    public partial class Sys
    {
        public decimal type { get; set; }
        public decimal id { get; set; }
        public decimal message { get; set; }
        public string country { get; set; }
        public decimal sunrise { get; set; }
        public decimal sunset { get; set; }
    }

    public partial class Clouds
    {
        public decimal all { get; set; }
    }

    public partial class Wind
    {
        public decimal speed { get; set; }
        public decimal deg { get; set; }
    }

    public partial class Main
    {
        public decimal temp { get; set; }
        public decimal pressure { get; set; }
        public decimal humidity { get; set; }
        public decimal temp_min { get; set; }
        public decimal temp_max { get; set; }
    }

    public partial class Weather
    {
        public decimal id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public partial class Coord
    {
        public decimal lon { get; set; }
        public decimal lat { get; set; }
    }
}


