using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_1.Models
{
    internal class Route
    {
        [Key]

        public int RouteID { get; set; }

        [Required]
        [Column (TypeName ="decimal(10,2)")]
        public decimal Distance { get; set; }


        public string ? Origin { get; set; }
    }
}
