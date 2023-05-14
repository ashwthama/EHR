using EHR.Domain.Model;

namespace EHR.Repo.UserRepo
{
    public interface IUserRepository
    {
        User GetByUserId(int userId);
        List<User> ListOfUser();
        User LoginUser(string username, string password);
        void RegisterUser(User userValue);
        void UpdateUser(User olddata, User newdata);
    }
}