using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFirstFunction.CheckerPassword
{
    public class CheckerPasswordLenght : PasswordDecorator
    {
        public CheckerPasswordLenght(ICheckerPassword passwordValidator, string password) : base(passwordValidator, password)
        {
            MyErrorMessage = "Password must be at least 8 characters";
        }
        protected override bool MyValidator() => Password.Length > 7;
    }
}
