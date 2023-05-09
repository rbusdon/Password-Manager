using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgramFirstFunction.CheckerPassword
{
    public class CheckerPasswordSpecialChar : PasswordDecorator
    {
        public CheckerPasswordSpecialChar(ICheckerPassword passwordValidator) : base(passwordValidator)
        {
            MyErrorMessage = "Password must be at least one special char";
        }
        protected override bool MyValidator(string password)
        {
            Regex regex = new Regex("^[a-zA-Z0-9 ]*$");

            if (regex.IsMatch(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
