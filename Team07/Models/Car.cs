using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team07.Models
{
    public class Car
    {
        public int Id { get; set; }
        [ForeignKey("Given")]
        public string Given { get; set; }
        [ForeignKey("Family")]
        public string Family { get; set; }
        [Required]
        [StringLength(150, MinimumLength=3)]
        [Display(Name ="Term")]
        public string GraduationTerm { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 3)]
        [Display(Name  = "Position")]
        public string DesiredPosition { get; set; }
        public string Skills { get; set; }
        public int Rating { get; set; }
        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
    }
}
