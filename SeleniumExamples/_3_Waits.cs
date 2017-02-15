using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExamples.Scaffolding;
using Xunit;

namespace SeleniumExamples
{
    [Collection(nameof(SeleniumTestCollection))]
    public class _3_Waits
    {
        private const string TestPageUrl = "http://localhost:59837/Examples/Wait";

        public _3_Waits(ChromeDriverFixture chromeDriverFixture)
        {
            Driver = chromeDriverFixture.Driver;
        }

        private ChromeDriver Driver { get; }

        [Fact]
        public void Exception_Thrown_When_No_Wait_Is_Configured()
        {
            Driver.Navigate().GoToUrl(TestPageUrl);
            Assert.Throws(typeof(NoSuchElementException), () => Driver.FindElementById("loaded"));
        }

        [Fact]
        public void Implicit_Wait()
        {
            try
            {
                Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
                Driver.Navigate().GoToUrl(TestPageUrl);
                Assert.NotNull(Driver.FindElementById("loaded"));
            }
            finally
            {
                Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(0));
            }
        }

        [Fact]
        public void Explicit_Wait()
        {
            Driver.Navigate().GoToUrl(TestPageUrl);

            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            var expected = wait.Until(d => d.FindElement(By.Id("loaded")));

            Assert.NotNull(expected);
        }
    }
}
