using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_ITI.Models
{
    internal class Instructors
    {
      
            [Key]

            public int InstructorId { get; set; }

            [Required]
            [Length(10, 50)]
            public string InstructorName { get; set; }

            [Required]
            public string Addres { get; set; }

            [Column(TypeName = "decimal(10,2)")]
            public decimal Bouns { get; set; }

            [Required]
            [Column(TypeName = "decimal(10,2)")]
            public decimal Salary { get; set; }




            [Required]
            [Column(TypeName = "decimal(10,2)")]
            public decimal HourRate { get; set; }


            public int DepartMentId { get; set; }


        
    }
}
