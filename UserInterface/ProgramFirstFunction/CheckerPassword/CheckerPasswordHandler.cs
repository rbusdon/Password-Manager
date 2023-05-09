using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFirstFunction.CheckerPassword
{
    public class CheckerPasswordHandler
    {
        public bool GetCheck(string password)
        {
            ICheckerPassword checker = Init();
            return checker.IsValid(password);
        }
        //public static (bool, string) GetResponse(string password)
        //{
        //    IChecker checker = Init(password);
        //    return (checker.IsValid(), checker.ErrorMessage());
        //}
        private static ICheckerPassword Init()
        {
            ICheckerPassword passwordChecker = new CheckerPassword();
            passwordChecker = new CheckerPasswordLenght(passwordChecker);
            passwordChecker = new CheckerPasswordNumber(passwordChecker);
            passwordChecker = new CheckerPasswordUpper(passwordChecker);
            passwordChecker = new CheckerPasswordSpecialChar(passwordChecker);
            return passwordChecker;
        }
    }
}
