using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_1.Models
{

    internal class AireCraft
    {

        [Key]
        public int CraftId { get; set; }

        [Column("CapacityOfCraft")]
        [Range(150,300)]
        public int Capacity { get; set; }


        public int Model{ get; set; }


        public int MajPilot { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 7, ErrorMessage = "invalied name")]
        public string AssitantName { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 7, ErrorMessage = "invalied name")]
        public string Host1 { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 7, ErrorMessage = "invalied name")]
        public string Host2 { get; set; }

        public int AireLineId{ get; set; }



    }
}
