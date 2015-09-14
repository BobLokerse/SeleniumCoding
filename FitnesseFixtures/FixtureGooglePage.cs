using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Tahzoo.SeleniumCode.Samples.PageObjects;

namespace Tahzoo.FitnesseFixtures
{
    public class FixtureGooglePage :
        fit.ColumnFixture
    {
        private IWebDriver _driver;
        private GooglePage _googlePage;

        protected FirefoxDriver GetFirefoxDriver()
        {
            return new FirefoxDriver();
        }


        public void OpenPage(string homepage)
        {
            _driver = GetFirefoxDriver();

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
