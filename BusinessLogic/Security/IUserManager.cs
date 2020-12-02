using BusinessLogic.Models;
using System.Threading.Tasks;

namespace BusinessLogic.Security
{
    public interface IUserManager
    {
        Task<UserOpResult> TryLoginAsync(LoginUserDto user);
        Task<UserOpResult> TrySignUpAsync(CreateUserDto user);
    }
}
