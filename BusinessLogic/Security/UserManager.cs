using AutoMapper;
using BusinessLogic.Exceptions;
using BusinessLogic.Models;
using DataAccess;
using DataAccess.Contexts;
using DataAccess.Models;
using System;
using System.Data.Entity;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace BusinessLogic.Security
{
    public class UserManager : IUserManager, IDisposable
    {
        private readonly UserContext userContext;
        private readonly IMapper mapper;
        public UserManager(UserContext userContext, IMapper mapper)
        {
            this.userContext = userContext;
            this.mapper = mapper;
        }

        public void Dispose()
        {
            userContext.Dispose();
        }

        public async Task<UserOpResult> TryLoginAsync(LoginUserDto user)
        {
            try
            {
                #region CheckIfEmpty
                if (user.Email == string.Empty || user.Email == null)
                {
                    throw new ArgumentException($"{nameof(user)} has an empty {nameof(user.Email)}.");
                }
                if (user.Password == string.Empty || user.Password == null)
                {
                    throw new ArgumentException($"{nameof(user)} has an empty {nameof(user.Password)}.");
                }
                #endregion
                var foundUser = await userContext.Users
                    .FirstOrDefaultAsync(x => x.Email == user.Email);

                if (foundUser == null)
                {
                    throw new BadLoginException($"{nameof(user)} with username {user.Email} does not exist");
                }

                if (foundUser.Password != user.Password)
                {
                    throw new BadLoginException($"Wrong password.");
                }
                return new UserOpResult { User = foundUser, Exception = null };
            }
            catch (Exception e)
            {
                return new UserOpResult
                {
                    User = null,
                    Exception = e
                };
            }
        }

        public async Task<UserOpResult> TrySignUpAsync(CreateUserDto user)
        {
            var userEntity = new User();
            try
            {
                if (await userContext.Users.AnyAsync(x => x.Email == user.Email))
                    throw new BadEmailException($"The user with email {user.Email} already exists.");
                userEntity = mapper.Map<User>(user);
                userContext.Users.Add(userEntity);
                await userContext.SaveChangesAsync();
                return new UserOpResult { User = userEntity, Exception = null };
            }
            catch (SocketException) // костыль, связанный с реализацией сокетов в .NET Full Framework
            {
                return new UserOpResult { User = userEntity, Exception = null };
            }
            catch (Exception e)
            {
                return new UserOpResult { User = null, Exception = e };
            }
        }
    }
}
