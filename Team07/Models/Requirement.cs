using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team07.Models
{
    public class Requirement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RequirementID { get; set; }
        public string RequirementAbbrev { get; set; }
        public string CourseName { get; set; }

    }
}