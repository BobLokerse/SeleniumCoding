using OpenQA.Selenium;
using Tahzoo.SeleniumCode.PmTool.PageObjects;

namespace Tahzoo.SeleniumCode.PmTool
{
    public class OpportunityPageTester
    {
        private readonly IWebDriver _driver;

        public OpportunityPageTester(Browser browser)
        {
            _driver = DriverFactory.GetDriver(browser);
        }

        public OpportunitiesBasicPage Login(string username, string password)
        {
            _driver.Navigate().GoToUrl(LoginCheck.TestSiteUrl);

            var loginPage = new LoginPage(_driver);
            loginPage.SetUsername(username);
            loginPage.SetPassword(password);

            return loginPage.LoginExpectingSuccess();
        }

        public int SearchOpportunitiesCountingResults(OpportunitiesDetailsPage opportunitiesPage, string searchText)
        {
            opportunitiesPage.EnterSearch(searchText);

            return opportunitiesPage.GetOpportunityCount();
        }
    }
}
