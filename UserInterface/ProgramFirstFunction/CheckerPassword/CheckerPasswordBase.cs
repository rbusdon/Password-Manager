using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFirstFunction.CheckerPassword
{
    public abstract class CheckerPasswordBase : ICheckerPassword
    {
        protected ICheckerPassword? _nextChecker;
        protected string MyErrorMessage;

        protected CheckerPasswordBase()
        {
            MyErrorMessage = string.Empty;
        }
        public abstract (bool, string) IsValid(string password);
            //=> _nextChecker.IsValid(password) && MyValidator(password);
        public void SetNext(ICheckerPassword next)
        {
            _nextChecker = next;
        }
    }
}
