using EHR.Domain.Model;

namespace EHR.Service.UserServices
{
    public interface IUserService
    {
        User GetByUserId(int userId);
        List<User> GetUserList();
        User LoginUser(string username, string password);
        void RegisterUser(User userValue);
    }
}