using OpenQA.Selenium.Chrome;
using SeleniumExamples.Fixtures;
using Xunit;

namespace SeleniumExamples
{
    [Collection(nameof(WebAppFixture))]
    public class _2_Running_A_Web_App
    {
        /* 
         * This is a bare minimum example of starting IIS Express to run a web application for testing.
         * It uses xUnit collection fixtures to start the web application before running the test.
         * Only a single instance of the application is started and is shared between all tests in the collection.
         */

        [Fact]
        public void Run_Application_And_Navigate_To_Home_Page()
        {
            using (var driver = new ChromeDriver(ProjectDirectories.GetDriversDirectory()))
            {
                driver.Navigate().GoToUrl("http://localhost:59837/");
                driver.FindElementById("hello");
            }
        }
    }
}
