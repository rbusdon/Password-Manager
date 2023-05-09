using UserInterface.Models.DB;

namespace DatabaseManager.Repositories
{
    public interface IUserRepository
    {
        public bool IsNameValid(string email);
        public void CreateAccount(User user);
        public int GetId(User user);
        public bool IsIdValid(int id);
        public User? GetUser(int id);
    }
}