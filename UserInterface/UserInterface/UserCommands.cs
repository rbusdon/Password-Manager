using ProgramFirstFunction;

namespace UserInterface
{
    public class UserCommands
    {
        public void Commands()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("What operation do you need to do?\nDigit 1 to Creare a new Account" +
                        "\nDigit 2 to Print all of your data\nDigit \"End\" to Close the Password Manager");
                    var input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            var firstFunction = new CreateAccount();
                            firstFunction.InputInformations();
                            break;
                        case "2":
                            //SecondFunction
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                    if (input == "End")
                    {
                        break;
                    }
                }
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Error: Input not valid. Cannot find any command with this input");
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown Error");
            }
        }
    }
}
