using System.ComponentModel.DataAnnotations;
using System;

namespace Domain
{
    public class CounselorRegistry
    {
        public int Id { get; set; }
        [Required] 
        public Counselor Counselor { get; set; }

        public int CounselorId { get; set; }
        [Required]
        public Cabin Cabin { get; set; }
        public int CabinId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime AssignmentStart { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime AssignmentEnd { get; set; }

        public string Notes { get; set; }
    }
}