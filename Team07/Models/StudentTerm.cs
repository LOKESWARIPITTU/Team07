using System;
using System.Collections.Generic;

namespace Team07.Models
{
    public class StudentTerm
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public string Term { get; set; }
        public string TermLabel { get; set; }

        public ICollection<Student> StudentID { get; set; }
    }
}