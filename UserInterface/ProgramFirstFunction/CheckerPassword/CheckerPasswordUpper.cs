using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgramFirstFunction.CheckerPassword
{
    public class CheckerPasswordUpper : CheckerPasswordBase
    {
        public CheckerPasswordUpper()
        {
            MyErrorMessage = "Password must be at least one capital letter";
        }

        public override (bool, string) IsValid(string password)
        {
            if (password.Any(char.IsUpper))
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
