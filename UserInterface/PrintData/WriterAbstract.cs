using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSecondFunction
{
    public class WriterAbstract
    {
        protected readonly string _currentDirectory = null!;
        public WriterAbstract()
        {
            _currentDirectory = Directory.GetCurrentDirectory();
        }
    }
}
