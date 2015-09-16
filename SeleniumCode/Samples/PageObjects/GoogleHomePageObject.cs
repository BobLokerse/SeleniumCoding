using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Tahzoo.SeleniumCode.Helpers;


namespace Tahzoo.SeleniumCode.Samples.PageObjects
{
    // https://seleniumautomation84.wordpress.com/2014/03/06/page-object-model-tutorial-using-selenium-webdriver-in-c-visual-studio-and-vs-unittest-for-dummies/

    public class GooglePage
    {
        private readonly IWebDriver _driver;
        
        /// <summary>
        /// Define a property for the search box on the Google page, for clearer use.
        /// The annotation holds the  actual name of the html element.
        /// </summary>
        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement SearchBox { get; set; }

        public GooglePage(IWebDriver driver)
        {
            this._driver = driver;

            // Initiate the elements on the page, like the SearchBox property.
            PageFactory.InitElements(_driver, this);
        }

        public void OpenPage(string homepage)
        {
            _driver.Navigate().GoToUrl(homepage);
        }

        public void SearchFor(string searchTerm)
        {
            SearchBox.SendKeys(searchTerm);
            SearchBox.Submit();
        }

        public string PageTitle()
        {
            WaitHelper.WaitUntilCondition(d => d.Title.ToLower().Contains("google"), _driver);

            return _driver.Title;
        }

        

        public void Close()
        {
            _driver.Close();
        }


    }
    
}
