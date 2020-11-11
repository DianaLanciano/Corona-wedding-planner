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
        [DisplayName("Supplire Email")]
        public string supplierEmail { get; set; }
        [DisplayName("Music Type")]
        public string musicType { get; set; }//Dj, Singer, LiveBand
        [DisplayName("Image Adress")]
        public string imagePath { get; set; }
        [Required]
        public int price { get; set; }
        [DisplayName("Name(of DJ/Band/Singer)")]
        public string name { get; set; }

    }
}

