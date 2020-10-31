using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaWedding.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        [Required]
        public int placeCapacity { get; set; }
        public string supplireEmail { get; set; }
        public string area { get; set; }
        public string city { get; set; }
        public string imagePath { get; set; }
        public double price { get; set; }
        //For google maps
        public double Latitude { get; set; }
        public double Longitude { get; set; }




    }
}
