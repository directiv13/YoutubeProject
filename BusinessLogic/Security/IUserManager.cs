using BusinessLogic.Models;
using System;
using System.Threading.Tasks;

namespace BusinessLogic.Security
{
    public interface IUserManager : IDisposable
    {
        Task<UserOpResult> TryLoginAsync(LoginUserDto user);
        Task<UserOpResult> TrySignUpAsync(CreateUserDto user);
    }
}
