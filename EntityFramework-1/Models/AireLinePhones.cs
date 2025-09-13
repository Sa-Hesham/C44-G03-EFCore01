using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_1.Models
{
    internal class AireLinePhones
    {
        [Key]
        public int AireLine_Id{ get; set; }


        [Required]
        [Phone] 

        public int Phones {  get; set; }

    }
}
