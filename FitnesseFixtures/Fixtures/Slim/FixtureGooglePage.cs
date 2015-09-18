using OpenQA.Selenium;
using Tahzoo.SeleniumCode.Helpers;
using Tahzoo.SeleniumCode.Samples.PageObjects;

namespace Tahzoo.FitnesseFixtures.Fixtures.Slim
{
    public class FixtureGooglePage
    {
        #region Fields and Constructor
        private readonly IWebDriver _driver;
        private GooglePage _googlePage;

        public FixtureGooglePage()
        {
            _driver = Browser.GetFirefoxDriver();
        }
        #endregion


        public void OpenPage(string homepage)
        {
            _googlePage= new GooglePage(_driver);

            _googlePage.OpenPage(homepage);
        }

        public void SearchFor(string searchTerm)
        {
            _googlePage.SearchFor(searchTerm);
        }

        public void ClickSearchButton()
        {
            _googlePage.ClickSearch();
        }

        public void ClickLuckyButton()
        {
            _googlePage.ClickLuckyButton();
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
