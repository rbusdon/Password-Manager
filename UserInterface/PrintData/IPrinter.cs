using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSecondFunction
{
    public interface IPrinter
    {
        public void WriteToFile(string fileName, string content);
    }
}
