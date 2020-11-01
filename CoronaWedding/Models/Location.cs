using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaWedding.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        [Required]
        [DisplayName("Place Cpacity")]
        public int placeCapacity { get; set; }
        [DisplayName("Supplire Email")]
        public string supplireEmail { get; set; }
        [DisplayName("Area")]
        public string area { get; set; }
        [DisplayName("City")]
        public string city { get; set; }
        [DisplayName("Image Adress")]
        public string imagePath { get; set; }
        public double price { get; set; }
        //For google maps
        public double Latitude { get; set; }
        public double Longitude { get; set; }




    }
}
