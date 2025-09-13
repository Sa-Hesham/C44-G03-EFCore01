using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_ITI.Models
{
    internal class CourseInstructor
    {
        [Key] 
        public int CourseId { get; set; }

        public int InsId { get; set; }

        public int Evaluation { get; set; }



    }
}
