using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaWedding.Models
{
    public class Photographer
    {
        public int PhotographerId { get; set; }
        public string supplireEmail { get; set; }
        public string imagePath { get; set; }
        public double price { get; set; }
    }
}
