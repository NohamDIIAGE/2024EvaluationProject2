using _2024Evaluation.DAL;
using _2024Evaluation.DAL.Contracts;
using _2024Evaluation.DAL.Repositories;
using _2024Evaluation.Services;
using _2024Evaluation.Services.Contracts;
using Microsoft.Azure.Functions.Worker;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Data;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices(services =>
    {
        services.AddDbContext<DbContextEntity>(options =>
        {
            options.UseSqlServer(Environment.GetEnvironmentVariable("EvaluationConnectionString"));
        });
        services.AddScoped<IEventRepository, EventRepository>();
        services.AddScoped<IEventService, EventService>();
    })
    .Build();

//Seed the databse
using (IServiceScope scope = host.Services.CreateScope())
{
    IServiceProvider serviceProvider = scope.ServiceProvider;

    var dbContext = serviceProvider.GetRequiredService<DbContextEntity>();
    dbContext.Database.EnsureCreated();
}

host.Run();
