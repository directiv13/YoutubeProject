using DataAccess.Models;
using System;

namespace BusinessLogic.Models
{
    public class UserOpResult
    {
        public User User { get; set; }
        public Exception Exception { get; set; }
    }
}
