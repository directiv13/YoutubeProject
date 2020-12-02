using System;
using System.ComponentModel.DataAnnotations;
namespace DataAccess.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string SecondName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string MotherTown { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
