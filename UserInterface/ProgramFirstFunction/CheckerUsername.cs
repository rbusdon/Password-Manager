using DatabaseManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface;
using UserInterface.Models.DB;

namespace ProgramFirstFunction
{
    public class CheckerUsername : ICheckerUsername
    {
        private readonly UsersAccountContext _context;
        private readonly UserRepository _userRepository;
        public CheckerUsername(UsersAccountContext context, UserRepository userRepository)
        {
            _context = context;
            _userRepository = userRepository;
        }
        public string ErrorMessage()
        {
            throw new NotImplementedException();
        }
        public bool IsValid(string username) => _userRepository.IsNameValid(username);
    }
}
