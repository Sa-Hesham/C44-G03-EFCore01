using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_1.Models
{
    internal class AircraftRoute
    {


        [Key]
            public int AC_Id { get; set; }          
            public int Route_Id { get; set; }     
            public string Departure { get; set; }   
            public int Num_Of_Pass { get; set; }   
            public decimal Price { get; set; }     
            public string Arrival { get; set; }    
        
    }
}
