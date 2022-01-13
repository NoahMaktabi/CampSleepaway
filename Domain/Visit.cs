using System;
using System.Collections.Generic;

namespace Domain
{
    public class Visit
    {
        public int Id { get; set; }
        public NextOfKin Visitor { get; set; }
        public int VisitorId { get; set; }

        public Camper Camper { get; set; }
        public int CamperId { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}