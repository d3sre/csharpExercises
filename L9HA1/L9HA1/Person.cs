using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9HA1
{
    [Table("Person")]
    class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime? HireDate { get; set; }

        public DateTime? EnrollmentDate { get; set; }

    }
}
