using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSecondFunction
{
    public interface ICsvConverter
    {
        public string ConvertToCsv(IConverterToCsv objectToConver);
    }
}
