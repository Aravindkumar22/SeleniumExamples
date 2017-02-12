using OpenQA.Selenium.Chrome;
using SeleniumExamples.Scaffolding;
using Xunit;

namespace SeleniumExamples
{
    public class _1_Bare_Minimum_Web_Driver_Example
    {
        /* 
         * This is a bare minimum example of using Selenium WebDriver in C#.
         * All that was required for this to run is
         *  - installing the Selenium.WebDriver nuget
         *  - installing the xunit and a xunit.runner (e.g. xunit.runners.visualstudio) nugets
         *  - downloading the Chrome driver - https://chromedriver.storage.googleapis.com/index.html
         */

        [Fact]
        public void Open_Google_Chrome()
        {
            using (var driver = new ChromeDriver(ProjectDirectories.GetDriversDirectory()))
            {
                driver.Navigate().GoToUrl("https://www.google.com.au");
            }
        }
    }
}
