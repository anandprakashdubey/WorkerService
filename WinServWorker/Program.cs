using WinServWorker;

Logger.Register();

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>(); // Replace with your service name
    })
    .UseWindowsService()
    .Build();

await host.RunAsync();