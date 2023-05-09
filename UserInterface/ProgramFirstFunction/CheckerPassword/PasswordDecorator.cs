using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFirstFunction.CheckerPassword
{
    public abstract class PasswordDecorator : ICheckerPassword
    {
        private readonly ICheckerPassword _passwordValidator;
        protected string MyErrorMessage = string.Empty;

        protected PasswordDecorator(ICheckerPassword passwordValidator)
        {
            _passwordValidator = passwordValidator;
        }

        public bool IsValid(string password) => _passwordValidator.IsValid(password) && MyValidator(password);

        public virtual string ErrorMessage() => MyErrorMessage;
        protected abstract bool MyValidator(string password);
    }
}
