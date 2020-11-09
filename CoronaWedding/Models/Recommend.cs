using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaWedding.Models
{
    public class Recommend
    {
        public int score { get; set; }
        public Photographer Photographer { get; set; }
    }
}
