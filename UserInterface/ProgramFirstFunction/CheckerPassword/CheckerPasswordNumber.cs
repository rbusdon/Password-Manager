using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgramFirstFunction.CheckerPassword
{
    public class CheckerPasswordNumber : PasswordDecorator
    {
        public CheckerPasswordNumber(ICheckerPassword passwordValidator, string password) : base(passwordValidator, password)
        {
            MyErrorMessage = "Password must be at least two digit";
        }

        protected override bool MyValidator() => Password.Count(char.IsNumber) > 1;
    }
}
