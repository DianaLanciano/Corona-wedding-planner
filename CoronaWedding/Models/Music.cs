using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaWedding.Models
{
    public class Music
    {
        public int MusicId { get; set; }
        [DisplayName("email to contact")]
        public string supplireEmail { get; set; }
        public string musicType { get; set; }//Dj, Singer, LiveBand
        public string imagePath { get; set; }
        [Required]
        [DisplayName("Price")]
        public int price { get; set; }
        public string name { get; set; }

    }
}

