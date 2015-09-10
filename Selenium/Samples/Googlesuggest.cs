using System;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
// Requires reference to WebDriver.Support.dll

namespace Tahzoo.SeleniumCode.Samples
{
    public class GoogleSuggest
    {
        public static string Search4Cheese()
        {
            // Create a new instance of the Firefox driver.

            // Notice that the remainder of the code relies on the interface, 
            // not the implementation.

            // Further note that other drivers (InternetExplorerDriver,
            // ChromeDriver, etc.) will require further configuration 
            // before this example will work. See the wiki pages for the
            // individual drivers at http://code.google.com/p/selenium/wiki
            // for further information.
            IWebDriver driver = new FirefoxDriver();

            //Notice navigation is slightly different than the Java version
            //This is because 'get' is a keyword in C#
            driver.Navigate().GoToUrl("http://www.google.com/");

            // Find the text input element by its name
            IWebElement query = driver.FindElement(By.Name("q"));

            // Enter something to search for
            query.SendKeys("Cheese");

            // Now submit the form. WebDriver will find the form for us from the element
            query.Submit();

            // Google's search is rendered dynamically with JavaScript.
            // Wait for the page to load, timeout after 10 seconds
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.ToLower().StartsWith("cheese"));

            // Should see: "Cheese - Google Search"
            string result = driver.Title;
            System.Console.WriteLine("Page title is: " + result);
            Debug.WriteLine("Page title is: " + result);

            //Close the browser
            driver.Quit();

            return result;
        }
    }
}