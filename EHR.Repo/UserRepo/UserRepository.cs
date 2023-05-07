using EHR.Domain.Context;
using EHR.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Repo.UserRepo
{
    public class UserRepository : IUserRepository
    {
        private readonly EhrContext _ehrContext;
        public UserRepository(EhrContext ehrContext)
        {
            _ehrContext = ehrContext;
        }
        public List<User> ListOfUser()
        {
            return _ehrContext.Usertable.ToList();
        }
        public User GetByUserId(int userId)
        {
            return _ehrContext.Usertable.FirstOrDefault(e => e.UserId == userId);
        }
        public void RegisterUser(User userValue)
        {
            _ehrContext.Usertable.Add(userValue);
            _ehrContext.SaveChanges();
        }

        public User LoginUser(string username, string password)
        {
            return _ehrContext.Usertable.FirstOrDefault(e => e.Username == username && e.Password == password);
        }

    }
}
