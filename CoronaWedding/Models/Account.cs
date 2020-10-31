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
        [DisplayName("Event Date")]
        public DateTime? weddingDate { get; set; }
        public UserType Type { get; set; }
        

    }
}
