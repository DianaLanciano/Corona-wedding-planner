using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaWedding.Models
{
    public class Photographer
    {
        public int PhotographerId { get; set; }
        [DisplayName("Supplire Email")]
        public string supplireEmail { get; set; }
        [DisplayName("Image Adress")]
        public string imagePath { get; set; }
        public double price { get; set; }
    }
}
