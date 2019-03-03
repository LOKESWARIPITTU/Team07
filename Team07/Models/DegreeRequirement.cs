using System;
using System.Collections.Generic;

namespace Team07.Models
{
    public class DegreeRequirement
    {
        public int ID { get; set; }
        public ICollection<Degree> DegreeID { get; set; }
        public ICollection<Requirement> RequirementID { get; set; }
    }
}