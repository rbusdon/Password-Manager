using UserInterface.Models.DB;

namespace DatabaseManager.Repositories
{
    public interface IUserRepository
    {
        public void CreateAccount(User user);
        public bool IsNameValid(string email);
        public bool IsIdValid(int id);
        public int GetId(User user);
        public User? GetUser(int id);
    }
}