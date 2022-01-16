using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Camper
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "The name is too long, max 50 letters")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "The phone number is too long, max 20 letters")]
        public string PhoneNumber { get; set; }

        public Cabin Cabin { get; set; }
        public int? CabinId { get; set; }

        public List<NextOfKin> NextOfKins { get; set; } = new List<NextOfKin>();
    }
}