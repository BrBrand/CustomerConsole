using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConsole.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; } // Unique identifier for the customer.

        [Required]
        public string Name { get; set; } // Name of the customer.

        public int Age { get; set; } // Age of the customer.

        public string Email { get; set; } // Email address of the customer.
    }
}
