using DatabaseManager.Repositories;
using ProgramFirstFunction.CheckerPassword;
using UserInterface;
using UserInterface.Models.DB;

namespace ProgramFirstFunction
{
    public class CreateAccount : ICreateAccount
    {
        private readonly IUserRepository _userRepository;
        private readonly ICheckerUsername _checkerUsername;
        private readonly ICheckerPassword _checkerPassword;

        public CreateAccount(IUserRepository userRepository, ICheckerUsername checkerUsername, ICheckerPassword checkerPassword)
        {
            _userRepository = userRepository;
            _checkerUsername = checkerUsername;
            _checkerPassword = checkerPassword;
        }

        public (string name, string password) InputInformations()
        {
            Console.WriteLine("Insert your email address. It will function as your username.");
            var username = Console.ReadLine();
            Console.WriteLine("Insert your password. Your password must be composed of" +
                " at least 7 characters of which at least 1 Upper character, 1 number and 1 special character.");
            var password = Console.ReadLine();
            GenerateAccount(username, password);
            return (username, password);
        }
        private void GenerateAccount(string name, string password)
        {
            var firstCondition = _checkerUsername.IsValid(name);
            bool secondCondition = _checkerPassword.IsValid(password);
            if (firstCondition && secondCondition)
            {
                User newUser = new()
                {
                    Name = name,
                    Password = password,
                };
                _userRepository.CreateAccount(newUser);
                var newUserId = _userRepository.GetId(newUser);
                Console.WriteLine("{newUserId}");
            }
        }
    }
}
