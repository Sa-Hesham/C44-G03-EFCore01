using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_ITI.Models
{
    internal class Departments
    {

        [Key]
        public int DepartId { get; set; }

        [Required]
        public string DepartName { get; set; }


        [Required]
        public  DateTime HiringDate { get; set; }


        [Required]
        public int InstructorId { get; set; }
    }
}
