using System;
using OpenQA.Selenium;

namespace SeleniumExamples.PageObjects
{
    public class HomePage
    {
        public const string Url = "http://localhost:59837/";

        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            if (!IsCurrentPage(driver))
            {
                throw new Exception("Driver is not on the home page.");
            }

            _driver = driver;
        }

        public static bool IsCurrentPage(IWebDriver driver)
        {
            return driver.Url == Url;
        }
    }
}
