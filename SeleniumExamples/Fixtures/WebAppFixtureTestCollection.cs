using Xunit;

namespace SeleniumExamples.Fixtures
{
    /// <summary>
    /// This is an xUnit test collection for the WebAppFixture.
    /// Refer to https://xunit.github.io/docs/shared-context.html.
    /// </summary>
    [CollectionDefinition(nameof(WebAppFixture))]
    public class WebAppFixtureTestCollection : ICollectionFixture<WebAppFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}
