using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgramFirstFunction.CheckerPassword
{
    public class CheckerPasswordNumber : CheckerPasswordBase
    {
        public CheckerPasswordNumber()
        {
            MyErrorMessage = "Password must contain at least 1 number";
        }

        public override (bool, string) IsValid(string password)
        {
            if (password.Count(char.IsNumber) > 1)
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
