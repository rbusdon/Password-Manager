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
        private readonly string _username;
        public CheckerUsername(string username)
        {
            _username = username;
        }
        public string ErrorMessage()
        {
            throw new NotImplementedException();
        }
        public bool IsValid()
        {
            var dbContext = new UsersAccountContext();
            var dbManager = new UserRepository(dbContext);
            return dbManager.IsNameValid(_username);
        }
    }
}
