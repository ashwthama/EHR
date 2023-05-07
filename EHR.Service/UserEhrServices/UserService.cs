using EHR.Domain.Model;
using EHR.Repo.UserRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Service.UserServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public List<User> GetUserList()
        {
            return _userRepository.ListOfUser();
        }
        public User GetByUserId(int userId)
        {
            return _userRepository.GetByUserId(userId);
        }
        public void RegisterUser(User userValue)
        {
            _userRepository.RegisterUser(userValue);
        }

        public User LoginUser(string username, string password)
        {
            return _userRepository.LoginUser(username, password);
        }
    }
}
