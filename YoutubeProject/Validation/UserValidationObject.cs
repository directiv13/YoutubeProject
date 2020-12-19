using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeProject
{
    public class UserValidationObject
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string SecondName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string MotherTown { get; set; }

        [Required, RegularExpression(@"^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$",ErrorMessage = "The birth date field format: mm/dd/yyyy.")]
        public string BirthDate { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
