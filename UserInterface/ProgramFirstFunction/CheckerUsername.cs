using DatabaseManager.Repositories;
using UserInterface.Models.DB;

namespace ProgramFirstFunction
{
    public class CheckerUsername : ICheckerUsername
    {
        private readonly UsersAccountContext _context;
        private readonly UserRepository _userRepository;
        private readonly string MyErrorMessage;
        public CheckerUsername(UsersAccountContext context, UserRepository userRepository)
        {
            _context = context;
            _userRepository = userRepository;
            MyErrorMessage = "Name not valid";
        }

        public (bool, string) IsValid(string username) => _userRepository.IsNameValid(username) ? (true, string.Empty) : (false, MyErrorMessage);
    }
}
