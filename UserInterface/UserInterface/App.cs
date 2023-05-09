using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public class App : IApp, IHostedService
    {
        private readonly UserCommands _commands;
        private readonly ConsoleCommands _commandsConsole;
        public App(UserCommands commands, ConsoleCommands commandsConsole)
        {
            _commands = commands;
            _commandsConsole = commandsConsole;
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _commandsConsole.Start();
            _commands.Commands();
            _commandsConsole.End();
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
        }
    }
}
