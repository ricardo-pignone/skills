using Xunit;

public class ServiceTests :
    IClassFixture<TestFixture>
{
    private readonly TestFixture fixture;

    public ServiceTests(TestFixture fixture)
    {
        this.fixture = fixture;
    }
}
