using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_1.Models
{
    internal class Employee
    {
        [Column("EmpId")]
        public int EmployeeId { get; set; }

        [Required]
        [Length(10, 50)]
        public string EmployeeName { get; set; }


        public string? Address { get; set; }

        [Required]
        [AllowedValues('F','f','M' ,'m')]
        public char Gendar { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        [Range(1972,2005)]
        public int BirthYear { get; set; }

        [Required]
        [AllowedValues(1,2,3,4,5,6,7,8,9,10,11,12)]
        public int  BirthMonth { get; set; }


        [Required]
        [Range(1,31)]
        public int BirthDay { get; set; }

        [Required]
        public int AireLinesID{ get; set; }




    }
}
