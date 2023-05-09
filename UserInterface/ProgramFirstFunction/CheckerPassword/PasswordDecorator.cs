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
        protected readonly string Password;
        protected string MyErrorMessage = string.Empty;

        protected PasswordDecorator(ICheckerPassword passwordValidator, string password)
        {
            _passwordValidator = passwordValidator;
            Password = password;
        }

        public bool IsValid() => _passwordValidator.IsValid() && MyValidator();

        public string ErrorMessage() =>
            !MyValidator() ? $"{_passwordValidator.ErrorMessage()}{Environment.NewLine}{MyErrorMessage}" : _passwordValidator.ErrorMessage();
        protected abstract bool MyValidator();

    }
}
