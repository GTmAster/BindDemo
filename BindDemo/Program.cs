using BindDemo.Configuration;
using BindDemo.Services;

await Host.CreateDefaultBuilder(args)
    .ConfigureHostConfiguration(builder =>
    {
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("appsettings.json");
    })
    .ConfigureServices((context, services) =>
    {
        services.AddHostedService<MyService>();
        services.AddOptions<Settings>().Bind(context.Configuration.GetRequiredSection("Settings"));
    })
    .Build()
    .RunAsync();