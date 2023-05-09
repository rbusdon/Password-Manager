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
        public CheckerPasswordNumber(ICheckerPassword passwordValidator) : base(passwordValidator)
        {
            MyErrorMessage = "Password must be at least two digit";
        }

        protected override bool MyValidator(string password) => password.Count(char.IsNumber) > 1;
    }
}
