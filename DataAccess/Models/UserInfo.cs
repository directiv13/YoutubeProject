using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class UserInfo
    {
        [Key]
        public int UserInfoId { get; set; }

        [Required]
        public int UsedId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string SecondName { get; set; }

        [Required]
        public string MotherTown { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public User user { get; set; }
    }
}
