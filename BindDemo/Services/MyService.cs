using BindDemo.Configuration;
using Microsoft.Extensions.Options;

namespace BindDemo.Services;

public class MyService: IHostedService
{
    private readonly ILogger<MyService> _logger;
    private readonly IOptions<Settings> _options;

    public MyService(ILogger<MyService> logger, IOptions<Settings> options)
    {
        _logger = logger;
        _options = options;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        foreach (var (name, environment) in _options.Value.Environments)
        {
            _logger.LogInformation($"{name}: Uri = {environment.BaseUri}");
        }
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}