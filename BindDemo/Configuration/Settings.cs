namespace BindDemo.Configuration;

public class Settings
{
    public IDictionary<string, Environment> Environments { get; set; }
}

public class Environment
{
    public string BaseUri { get; set; }
}