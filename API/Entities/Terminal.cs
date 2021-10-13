using System;

namespace API.Entities
{
    public class Terminal 
    {
        public int Id { get; set; }
        public DateTime CurrentTime { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double speed { get; set; }
    }
}