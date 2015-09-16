using OpenQA.Selenium;
using Tahzoo.SeleniumCode.Helpers;
using Tahzoo.SeleniumCode.Samples.PageObjects;

namespace Tahzoo.FitnesseFixtures.Fixtures
{
    public class FixtureGooglePage :
        fit.ColumnFixture
    {
        private readonly IWebDriver _driver;
        private GooglePage _googlePage;

        public FixtureGooglePage()
        {
            _driver = Browser.GetFirefoxDriver();
        }


        public void OpenPage(string homepage)
        {
            _googlePage= new GooglePage(_driver);

            _googlePage.OpenPage(homepage);
        }

        public void SearchFor(string searchTerm)
        {
            _googlePage.SearchFor(searchTerm);
        }

        public string PageTitle()
        {
            return _googlePage.PageTitle();
        }

        public void Close()
        {
            _googlePage.Close();
        }
    }
}
