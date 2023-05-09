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
        public CheckerPasswordSpecialChar(ICheckerPassword passwordValidator, string password) : base(passwordValidator, password)
        {
            MyErrorMessage = "Password must be at least one special char";
        }
        protected override bool MyValidator()
        {
            Regex regex = new Regex("^[a-zA-Z0-9 ]*$");

            if (regex.IsMatch(Password))
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
