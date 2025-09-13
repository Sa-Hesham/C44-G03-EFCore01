using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_1.Models
{

    [Table("AireLine_Company")]
    internal class AireLine
    {
        [Key]
        public int Aire_Id { get; set; }

        [Required]
        [MaxLength(50 ,ErrorMessage ="invalid input")]
        [MinLength(15, ErrorMessage = "invalid input")]
        public String Name { get; set; }



        public String? Address { get; set; }


        [Column ("Contatct_Person")]
        public  int Cont_Person { get; set; }


    }
}
