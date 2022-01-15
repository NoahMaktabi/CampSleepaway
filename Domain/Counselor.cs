using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Counselor
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "The name is too long, max 50 letters")]
        public string Name { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "The address is too long, max 100 letters")]
        public string Address { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "The phone number is too long, max 20 letters")]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public bool AssignedToCabin { get; set; } = false;
    }
}