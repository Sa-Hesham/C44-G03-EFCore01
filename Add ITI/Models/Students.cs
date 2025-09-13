using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_ITI.Models
{
    internal class Students
    {
        [Key]
        [Column("StudId")] 
        
        public int StudentId { get; set; }

        [Required]
        [MaxLength(40,ErrorMessage ="invalid name")]
        [MinLength(10, ErrorMessage = "invalid name")]
        public string FirstName { get; set; }
        public string ? LastName { get; set; }

        [Range(18,30)]
        public int Age { get; set; }

        public string?  Address { get; set; }

        [Column("DeptId")]
        public int DepartmentId { get; set; }

    }
}
