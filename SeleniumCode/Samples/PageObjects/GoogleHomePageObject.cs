using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


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
            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys(searchTerm);
            query.Submit();
        }

        public string PageTitle(FirefoxDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.ToLower().EndsWith("search"));

            return driver.Title;
        }

        public void Close(FirefoxDriver driver)
        {
            driver.Close();
        }

    }
    
}
