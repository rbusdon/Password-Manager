using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSecondFunction
{
    public interface IConverterToCsv
    {
        public List<string> ConvertFieldsToStringList();
    }
}
