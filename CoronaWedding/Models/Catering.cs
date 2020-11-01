using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaWedding.Models
{
    public class Catering
    {
        public int CateringId { get; set; }
        public string foodType { get; set; }//Asian, meaty, vegan
        [DisplayName("Supplire Email")]
        public string supplireEmail { get; set; }
        [Required]
        [DisplayName("Price")]
        public int price { get; set; }
        [DisplayName("Image Adress")]
        public string imagePath { get; set; }
    }
}
