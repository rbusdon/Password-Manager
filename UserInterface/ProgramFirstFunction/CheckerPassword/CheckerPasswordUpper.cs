using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFirstFunction.CheckerPassword
{
    public class CheckerPasswordUpper : PasswordDecorator
    {
        public CheckerPasswordUpper(IChecker passwordValidator, string password) : base(passwordValidator, password)
        {
            MyErrorMessage = "Password must be at least one capital letter";
        }

        protected override bool MyValidator() => Password.Any(char.IsUpper);
    }
}
