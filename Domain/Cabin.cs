using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Cabin
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "The name is too long, max 50 letters")]
        public string Name { get; set; }

        public List<Camper> Campers { get; set; }

        [ForeignKey("CounselorId")]
        public Counselor Counselor { get; set; }
        public int CounselorId { get; set; }
    }
}