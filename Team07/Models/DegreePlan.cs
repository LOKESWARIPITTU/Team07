using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team07.Models
{
    public class DegreePlan
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreePlanId { get; set; }

        public int DegreeID { get; set; }
        public int StudentID { get; set; }
        public string DegreePlanAbbrev { get; set; }
        public string DegreePlanName { get; set; }


    }
}