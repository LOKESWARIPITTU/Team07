using System;
using System.Collections.Generic;

namespace Team07.Models
{
    public class DegreePlan
    {


        public int ID { get; set; }

        public ICollection<Degree> DegreeID { get; set; }
        public ICollection<Student> StudentID { get; set; }
        public string DegreePlanAbbrev { get; set; }
        public string DegreePlanName { get; set; }


    }
}