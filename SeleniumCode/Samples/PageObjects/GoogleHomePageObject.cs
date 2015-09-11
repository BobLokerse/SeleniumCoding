using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace Tahzoo.SeleniumCode.Samples.PageObjects
{
    // https://seleniumautomation84.wordpress.com/2014/03/06/page-object-model-tutorial-using-selenium-webdriver-in-c-visual-studio-and-vs-unittest-for-dummies/

    public class GooglePage
    {
        public void OpenPage(string homepage, IWebDriver driver)
        {
            driver.Navigate().GoToUrl(homepage);
        }

        public void SearchFor(string searchTerm, FirefoxDriver driver)
        {
            driver.FindElementByName("q").SendKeys(searchTerm);
        }

        public void ClickSearch(FirefoxDriver driver)
        {
            driver.FindElementByName("btnK").Click();
        }

        public void ClickFeelingLucky(FirefoxDriver driver)
        {
            driver.FindElementByName("btnI").Click();
        }

    }
    
}
