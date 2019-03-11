using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team07.Models
{
    public class DegreePlanTermRequirement
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreePlanTermRequirementId { get; set; }
        public int DegreePlanID { get; set; }
        public int TermID { get; set; }
        public int RequirementID { get; set; }

    }

    }