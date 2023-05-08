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
            IChecker checker = Init(password);
            return checker.IsValid();
        }
        //public static (bool, string) GetResponse(string password)
        //{
        //    IChecker checker = Init(password);
        //    return (checker.IsValid(), checker.ErrorMessage());
        //}
        private static IChecker Init(string password)
        {
            IChecker passwordChecker = new CheckerPassword(password);
            passwordChecker = new CheckerPasswordLenght(passwordChecker, password);
            passwordChecker = new CheckerPasswordNumber(passwordChecker, password);
            passwordChecker = new CheckerPasswordUpper(passwordChecker, password);
            passwordChecker = new CheckerPasswordSpecialChar(passwordChecker, password);
            return passwordChecker;
        }
    }
}
