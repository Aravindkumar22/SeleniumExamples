using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace SeleniumExamples.PageObjects
{
    public class LoginPage
    {
        public const string Url = "http://localhost:59837/Login";
        public const string LoginFailureMessage = "Invalid username and password.";

        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            if (!IsCurrentPage(driver))
            {
                throw new Exception("Driver is not on the login page.");
            }

            _driver = driver;
        }

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement UsernameInput { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement PasswordInput { get; set; }

        [FindsBy(How = How.Id, Using = "login")]
        private IWebElement LoginButton { get; set; }

        [FindsBy(How = How.Id, Using = "message")]
        private IWebElement MessageContainer { get; set; }

        public static LoginPage GoTo(IWebDriver driver)
        {
            driver.Url = Url;

            return PageFactory.InitElements<LoginPage>(driver);
        }

        public static bool IsCurrentPage(IWebDriver driver)
        {
            return driver.Url == Url;
        }
        
        public string CurrentMessage()
        {
            return MessageContainer.Text;
        }

        public HomePage LoginSuccessfully(string username, string password)
        {
            UsernameInput.SendKeys(username);
            PasswordInput.SendKeys(password);
            LoginButton.Click();

            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.Until(d => HomePage.IsCurrentPage(d));

            return new HomePage(_driver);
        }

        public LoginPage LoginUnsuccessfully(string username, string password)
        {
            UsernameInput.SendKeys(username);
            PasswordInput.SendKeys(password);
            LoginButton.Click();
            
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.Until(d => CurrentMessage() == LoginFailureMessage);

            return new LoginPage(_driver);
        }
    }
}
