using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team07.Models
{
    public class Requirement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Display(Name = "Requirement Id")]
        public int RequirementID { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        [Display(Name = "Abbreviation")]
        public string RequirementAbbrev { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Name")]
        public string CourseName { get; set; }

    }
}