using SeleniumExamples.Fixtures;
using SeleniumExamples.PageObjects;
using Xunit;

namespace SeleniumExamples
{
    [Collection(nameof(SeleniumTestCollection))]
    public class _3_Testing_App_Behaviour
    {
        private readonly ChromeDriverFixture _fixture;

        public _3_Testing_App_Behaviour(ChromeDriverFixture chromeDriverFixture)
        {
            _fixture = chromeDriverFixture;
        }

        [Fact]
        public void Redirected_To_Home_Page_After_Successful_Login()
        {
            var loginPage = LoginPage.GoTo(_fixture.Driver);
            loginPage.LoginSuccessfully("user", "password");
            
            Assert.True(HomePage.IsCurrentPage(_fixture.Driver));
        }
    }
}
