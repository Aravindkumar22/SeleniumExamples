using System.IO;
using System.Reflection;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace SeleniumExamples
{
    public class WebDriverExamples
    {
        [Fact]
        public void Open_Google_Chrome()
        {
            var binDirectory = GetBinDirectory();
            var dependenciesDirectory = Path.Combine(binDirectory, "Dependencies");
            using (var driver = new ChromeDriver(dependenciesDirectory))
            {
                driver.Navigate().GoToUrl("https://www.google.com.au");
            }
        }

        private string GetBinDirectory()
        {
            var testAssemblyDirectory = Path.GetDirectoryName(Assembly.GetAssembly(typeof(WebDriverExamples)).CodeBase);
            return TrimSchemeFromUri(testAssemblyDirectory);
        }

        // From Marc Gravell's answer http://stackoverflow.com/a/4517321
        private string TrimSchemeFromUri(string uri)
        {
            int schemeEnd = uri.IndexOf(":");
            return uri.Substring(schemeEnd + 1)
                .TrimStart('\\');
        }
    }
}
