using DatabaseManager.Repositories;
using ProgramFirstFunction.CheckerPassword;
using UserInterface;
using UserInterface.Models.DB;

namespace ProgramFirstFunction
{
    public class CreateAccount
    {
        public (string name, string password) InputInformations ()
        {
            Console.WriteLine("Insert your email address. It will function as your username.");
            var username = Console.ReadLine();
            Console.WriteLine("Insert your password. Your password must be composed of" +
                " at least 7 characters of which at least 1 Upper character, 1 number and 1 special character.");
            var password = Console.ReadLine();
            GenerateAccount(username, password);
            return (username, password);
        }
        private void GenerateAccount (string name, string password)
        {
            var userChecker = new CheckerUsername();
            var passwordChecker = new CheckerPasswordHandler();
            var firstCondition = userChecker.IsValid();
            bool secondCondition = passwordChecker.GetCheck(password);
            if (firstCondition && secondCondition == true)
            {
                var dbContext = new UsersAccountContext();
                var dbManager = new UserRepository(dbContext);
                User newUser = new()
                {
                    Name = name,
                    Password = password,
                };
                dbManager.CreateAccount(newUser);
                var newUserId = dbManager.GetId(newUser);
                Console.WriteLine("{newUserId}");
            }
        }
    }
}
