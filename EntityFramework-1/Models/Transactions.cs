using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_1.Models
{
    internal class Transactions
    {

        [Key]
        public int TransactId{ get; set; }

        [Length(30,50,ErrorMessage ="invalied")]
        public String ?Description { get; set; }

        [Required]
        public int Amount { get; set; }


        public DateTime Date { get; set; }


        public int AireLineId {  get; set; }
    }
}
