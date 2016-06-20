using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidJarl_MVC_2016_06.Models
{
    public class Person
    {

        [Required]
        [KeyAttribute]
        public int PersonId { get; set; }

        [Required]
        [MaxLength(32)]
        public string FirstName { get; set; }

        //Some people only have one name. Hence, no [Required] here.
        [MaxLength(32)]
        public string LastName { get; set; }

        [Required]
        public string SocialSecurityNumber { get; set; }

        public List<CreditsCard> CreditsCards { get; set; }


    }
}
