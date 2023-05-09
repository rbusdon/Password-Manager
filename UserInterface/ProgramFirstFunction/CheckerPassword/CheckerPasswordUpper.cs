using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFirstFunction.CheckerPassword
{
    public class CheckerPasswordUpper : PasswordDecorator
    {
        public CheckerPasswordUpper(ICheckerPassword passwordValidator) : base(passwordValidator)
        {
            MyErrorMessage = "Password must be at least one capital letter";
        }

        protected override bool MyValidator(string password) => password.Any(char.IsUpper);
    }
}
