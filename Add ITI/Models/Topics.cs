using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_ITI.Models
{
    internal class Topics
    {
        [Key]

        public int TopicId { get; set; }

        [Required]
        public string TopicName { get; set; }
    }
}
