using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace UserInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Worker.CreateBuilder().Build().Run();
            //var builder = Worker.CreateBuilder().Build();
            //builder.Services.GetService<IApp>();
        }
    }
}