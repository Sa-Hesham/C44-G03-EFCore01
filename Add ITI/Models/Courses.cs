using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_ITI.Models
{
    internal class Courses
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public String CourseName { get; set; }

        public TimeOnly Duration { get; set; }


        public string ?Description { get; set; }

        public int TopicId  { get; set; }
    }
}
