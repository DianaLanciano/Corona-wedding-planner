using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace CoronaWedding.Models
{
    public class Account
    {
        public enum UserType
        {
            Member,
            Admin
        }
        public int AccountId { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }
        public string password { get; set; }
        [DisplayName("Wedding Date")]
        public DateTime? weddingDate { get; set; }
        public UserType Type { get; set; }
        //for cart
        public int CateringId { get; set; }
        public int LocationId { get; set; }
        public int MusicId { get; set; }
        public int PhotographerId { get; set; }


    }
}
