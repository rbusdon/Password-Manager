using static System.Data.Entity.Infrastructure.Design.Executor;

namespace UserInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
            var console = new ConsoleCommands();
            var userCommands = new UserCommands();
            console.Start();
            userCommands.Commands();
            console.End();
            Console.ReadKey();
        }
    }
}