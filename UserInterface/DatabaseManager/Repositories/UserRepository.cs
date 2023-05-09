using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DatabaseManager.Repositories.UserRepository;
using UserInterface.Models.DB;

namespace DatabaseManager.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UsersAccountContext _accountDBContext;
        public UserRepository(UsersAccountContext accountDBContext)
        {
            _accountDBContext = accountDBContext;
        }

        public void CreateAccount(User user)
        {
            try
            {
                _accountDBContext.Users.Add(user);
                _accountDBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unknown Error: cannot create any account with this name.");
                Console.Error.WriteLine(ex.Message);
            }
        }

        public bool IsNameValid(string name) => _accountDBContext.Users.Any(p => p.Name == name);
        public bool IsIdValid(int id) => _accountDBContext.Users.Any(p => p.Id == id);
        public int GetId(User user) => _accountDBContext.Users.First(p => p.Name == user.Name).Id;
        public User? GetUser(int Id) => _accountDBContext.Users.FirstOrDefault(p => p.Id == Id);
    }
}
