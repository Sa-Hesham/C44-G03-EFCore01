using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_ITI.Models
{
    [Table("Stud_Course")]
    internal class StudentCourse
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public int courseId{ get; set; }

        public int Grade{ get; set; }



    }
}
