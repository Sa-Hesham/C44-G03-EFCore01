using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_1.Models
{
    [Table("Emp_Cualifications")]
    internal class EmployeeCualifications
    {

        [Column("Emp_Id")]
        [Key]
        public int EmployeeId { get; set; }


        [Required]
        public string Qualifications {  get; set; }
    }
}
