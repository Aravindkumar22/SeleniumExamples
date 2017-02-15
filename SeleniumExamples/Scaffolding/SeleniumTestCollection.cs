using Xunit;

namespace SeleniumExamples.Scaffolding
{
    /// <summary>
    /// This is an xUnit test collection that starts the example web app and creates a ChromeDriver instance.
    /// Refer to https://xunit.github.io/docs/shared-context.html.
    /// </summary>
    [CollectionDefinition(nameof(SeleniumTestCollection))]
    public class SeleniumTestCollection : ICollectionFixture<WebAppFixture>, ICollectionFixture<ChromeDriverFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}
