using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Tahzoo.SeleniumCode.Samples.PageObjects;

namespace Tahzoo.FitnesseFixtures
{
    public class FixtureGooglePage : fit.ColumnFixture
    {
        private IWebDriver _driver;
        private GooglePage _googlePage;

        public void OpenPage(string homepage)
        {
            _driver = new FirefoxDriver();

            _googlePage= new GooglePage();

            _googlePage.OpenPage(homepage, (FirefoxDriver) _driver);
        }

        public void SearchFor(string searchTerm)
        {
            _googlePage.SearchFor(searchTerm, (FirefoxDriver) _driver);
        }

        public string PageTitle()
        {
            return _googlePage.PageTitle((FirefoxDriver) _driver);
        }

        public void Close()
        {
            _googlePage.Close((FirefoxDriver)_driver);
        }
    }
}
