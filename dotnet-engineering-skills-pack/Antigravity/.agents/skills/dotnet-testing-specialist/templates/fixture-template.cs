using Xunit;

public class IntegrationFixture : IAsyncLifetime
{
    public async Task InitializeAsync()
    {
        // Initialize shared resources
    }

    public async Task DisposeAsync()
    {
        // Dispose resources
    }
}

[CollectionDefinition("Integration")]
public class IntegrationCollection :
    ICollectionFixture<IntegrationFixture>
{
}
