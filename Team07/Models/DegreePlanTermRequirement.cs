using System;
using System.Collections.Generic;

namespace Team07.Models
{
    public class DegreePlanTermRequirement
    {


        public int ID { get; set; }
        public ICollection<DegreePlan> DegreePlanID { get; set; }
        public int TermID { get; set; }
        public ICollection<Requirement> RequirementID { get; set; }

    }

    }