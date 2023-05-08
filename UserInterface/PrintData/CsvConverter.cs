using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSecondFunction
{
    public class CsvConverter : ICsvConverter
    {
        public string ConvertToCsv(IConverterToCsv objectToConver)
        {
            List<string>? fieldsList = objectToConver.ConvertFieldsToStringList();
            return String.Join(',', fieldsList);
        }
    }
}
