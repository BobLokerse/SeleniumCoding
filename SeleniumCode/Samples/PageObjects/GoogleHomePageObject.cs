using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace Tahzoo.SeleniumCode.Samples.PageObjects
{
    // https://seleniumautomation84.wordpress.com/2014/03/06/page-object-model-tutorial-using-selenium-webdriver-in-c-visual-studio-and-vs-unittest-for-dummies/

    public class GooglePage
    {
        private readonly IWebDriver _driver;

        public GooglePage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public void OpenPage(string homepage)
        {
            _driver.Navigate().GoToUrl(homepage);
        }

        public void SearchFor(string searchTerm)
        {
            IWebElement query = _driver.FindElement(By.Name("q"));
            query.SendKeys(searchTerm);
            query.Submit();
        }

        public string PageTitle()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.ToLower().EndsWith("search"));

            return _driver.Title;
        }

        public void Close()
        {
            _driver.Close();
        }


    }
    
}
