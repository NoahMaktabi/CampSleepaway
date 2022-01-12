using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class CamperRegistry
    {
        public int Id { get; set; }
        [Required]
        public Camper Camper { get; set; }
        public int CamperId { get; set; }
        [Required]
        public Cabin Cabin { get; set; }
        public int CabinId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CheckIn { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime CheckOut { get; set; }

        public string Notes { get; set; }
    }
}