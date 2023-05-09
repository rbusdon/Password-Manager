using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgramFirstFunction.CheckerPassword
{
    public class CheckerPasswordSpecialChar : CheckerPasswordBase
    {
        public CheckerPasswordSpecialChar()
        {
            MyErrorMessage = "Password must be at least one special char";
        }
        public override (bool, string) IsValid(string password)
        {
            Regex regex = new Regex("^[a-zA-Z0-9 ]*$");
            if (regex.IsMatch(password))
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
