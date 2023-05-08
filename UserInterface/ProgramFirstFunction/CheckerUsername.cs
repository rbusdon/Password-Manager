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
    public class CheckerUsername : IChecker
    {
        public bool Check(string username)
        {
            var dbContext = new UsersAccountContext();
            var dbManager = new UserRepository(dbContext);
            return dbManager.IsNameValid(username);
        }
        public string ErrorMessage()
        {
            throw new NotImplementedException();
        }
        public bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
