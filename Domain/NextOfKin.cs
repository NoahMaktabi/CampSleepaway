using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class NextOfKin
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "The name is too long, max 50 letters")]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "The phone number is too long, max 20 letters")]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public Camper Camper { get; set; }
        public int CamperId { get; set; }
    }
}