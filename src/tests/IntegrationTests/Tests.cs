namespace Creatomate.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static CreatomateClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("CREATOMATE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("CREATOMATE_API_KEY environment variable is not found.");

        var client = new CreatomateClient(apiKey);
        
        return client;
    }
}
