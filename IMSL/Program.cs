using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using IM.Domain;
using IM.Infrastructure;
var configurationBuilder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddUserSecrets(Assembly.GetExecutingAssembly())
    .Build();
var connectionString = configurationBuilder.GetConnectionString("DatabaseConnection")
        ?? throw new InvalidOperationException("Connection string not found"); ;

var options = new DbContextOptionsBuilder<ApplicationDbContext>()
    .UseSqlServer(connectionString)
    .Options;

using var context = new ApplicationDbContext(options);