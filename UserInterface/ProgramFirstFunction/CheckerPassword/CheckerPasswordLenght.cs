using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFirstFunction.CheckerPassword
{
    public class CheckerPasswordLenght : CheckerPasswordBase
    {
        public CheckerPasswordLenght()
        {
            MyErrorMessage = "Password must be at least 8 characters";
        }

        public override (bool, string) IsValid(string password)
        {
            if (password.Length > 7)
            {
                if (_nextChecker != null)
                {
                    return _nextChecker.IsValid(password);
                }
                return (true, string.Empty);
            }
            else
            {
                return (false, MyErrorMessage);
            }
        }
    }
}
