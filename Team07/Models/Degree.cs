using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team07.Models
{
    public class Degree
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeId { get; set; }
        public string DegreeAbrrev { get; set; }
        public string DegreeName { get; set; }
      

    }
}