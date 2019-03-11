using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team07.Models
{
    public class DegreeRequirement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeRequirementId { get; set; }
        public int DegreeId { get; set; }
        public int RequirementId { get; set; }
    }
}