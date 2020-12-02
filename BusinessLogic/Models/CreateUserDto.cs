using System;

namespace BusinessLogic.Models
{
    public class CreateUserDto
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string MotherTown { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
    }
}
