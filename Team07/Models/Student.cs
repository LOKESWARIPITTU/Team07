using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team07.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Snumber { get; set; }
        public int catpawsnum { get; set; }
    }
}