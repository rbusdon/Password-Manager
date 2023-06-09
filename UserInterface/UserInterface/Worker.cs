﻿using DatabaseManager.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProgramFirstFunction;
using ProgramFirstFunction.CheckerPassword;
using UserInterface.Models.DB;

namespace UserInterface
{
    public static class Worker
    {
        public static IHostBuilder CreateBuilder ()
        {
            //var MyConfig = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            return Host.CreateDefaultBuilder().ConfigureServices(services =>
            {
                services.AddTransient<ICreateAccount, CreateAccount>();
                services.AddTransient<IUserRepository, UserRepository>();
                services.AddTransient<ICheckerUsername, CheckerUsername>();
                services.AddDbContext<UsersAccountContext>(options => options.UseSqlServer("Data Source=localhost;Initial Catalog=UsersAccount; User Id=sa; Password=Eur66Bag; Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;"));
                services.AddTransient<UserCommands>();
                services.AddTransient<ConsoleCommands>();
                services.AddScoped<IApp, App>();
                services.AddSingleton<ICheckerPassword>(_ =>
                {
                    var passwordCheckerLenght = new CheckerPasswordLenght();
                    var passwordCheckerNumber = new CheckerPasswordNumber();
                    var passwordCheckerUpper = new CheckerPasswordUpper();
                    var passwordCheckerSpecialChar = new CheckerPasswordSpecialChar();
                    passwordCheckerLenght.SetNext(passwordCheckerNumber);
                    passwordCheckerNumber.SetNext(passwordCheckerUpper);
                    passwordCheckerUpper.SetNext(passwordCheckerSpecialChar);
                    return passwordCheckerLenght;
                });
            });
        }
    }
}

            //string? connectionString = context.Configuration.GetConnectionString("DB1");
            //service.AddScoped<IUserService, UserService>();
            //service.AddScoped<IUserRepository, UserRepository>();
            //service.AddTransient<IPasswordValidator>(_ => new AtLeastOneDigitPasswordValidator(validateSpecialChar));
            //service.AddDbContext<CredentialDBContext>(options => options.UseSqlServer(connectionString));
            //service.AddTransient<IFileWriter, FileWriter>();
            //service.AddTransient<ICsvConverter, CsvConverter>();
            //service.AddTransient<ICreateUserFileName, CreateUserFileName>();
