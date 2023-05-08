using ProgramSecondFunction;
using System.Text;

namespace PrintData
{
    public class Printer : WriterAbstract, IPrinter
    {
        public void WriteToFile(string fileName, string content)
        {
            StringBuilder filepath = new StringBuilder();
            filepath.Append(_currentDirectory);
            filepath.Append('/');
            filepath.Append(fileName);
            File.WriteAllText(filepath.ToString(), content);
        }
    }
}