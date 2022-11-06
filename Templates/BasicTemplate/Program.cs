using BasicProjectTemplate.Logic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SlipeServer.Server;
using SlipeServer.Server.Loggers;
using SlipeServer.Server.ServerBuilders;

var server = new MtaServer(builder =>
{

    builder.AddDefaults();

    builder.ConfigureServices(services =>
    {
        services.AddSingleton<ILogger, ConsoleLogger>();
    });

    builder.AddLogic<SpawnLogic>();
});
server.Start();
server.GetRequiredService<ILogger>().LogInformation("Server started.");
await Task.Delay(-1);
