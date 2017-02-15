using System;
using OpenQA.Selenium.Chrome;

namespace SeleniumExamples.Scaffolding
{
    /// <summary>
    /// Creates a ChromeDriver instance for use in Selenium tests.
    /// This is an xUnit fixture class. Refer to https://xunit.github.io/docs/shared-context.html.
    /// </summary>
    public class ChromeDriverFixture : IDisposable
    {
        public ChromeDriver Driver { get; }

        public ChromeDriverFixture()
        {
            Driver = new ChromeDriver(ProjectDirectories.GetDriversDirectory());
        }

        public void Dispose()
        {
            if (Driver != null)
            {
                Driver.Dispose();
            }
        }
    }
}
