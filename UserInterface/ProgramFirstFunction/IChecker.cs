using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFirstFunction
{
    public interface IChecker
    {
        bool IsValid();
        string ErrorMessage();
    }
}
