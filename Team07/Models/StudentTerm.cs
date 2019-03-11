using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team07.Models
{
    public class StudentTerm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentTermId { get; set; }
        public int StudentID { get; set; }
        public int Term { get; set; }
        public string TermLabel { get; set; }
        public int DegreePlanId { get; set; }
    }
}