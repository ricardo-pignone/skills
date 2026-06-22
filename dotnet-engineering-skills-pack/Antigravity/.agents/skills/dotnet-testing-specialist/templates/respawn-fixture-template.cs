using Respawn;
using Xunit;

public class DatabaseFixture : IAsyncLifetime
{
    public Respawner Respawner { get; private set; }

    public async Task InitializeAsync()
    {
        // Start TestContainer
        // Run migrations

        Respawner = await Respawner.CreateAsync(
            connectionString);
    }

    public async Task ResetDatabaseAsync()
    {
        await Respawner.ResetAsync(connectionString);
    }

    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }
}
