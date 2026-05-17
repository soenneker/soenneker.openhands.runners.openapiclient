using Soenneker.Tests.HostedUnit;

namespace Soenneker.OpenHands.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class OpenHandsOpenApiClientRunnerTests : HostedUnitTest
{
    public OpenHandsOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
